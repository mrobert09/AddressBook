using AddressBookLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBookLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Method that runs when Save button gets clicked. Inserts a name into the database and returns the ID the entry object with ID information.
        /// </summary>
        /// <param name="entry">Entry Object w/o ID</param>
        /// <param name="nameSelected">Name box from when EditForm loaded to determine if making a new entry or not.</param>
        /// <returns>Entry Object w/ ID</returns>
        public EntryModel SaveEntry(EntryModel entry, string nameSelected)
        {

            DynamicParameters p;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                // Warn user over possible name conflicts, exit out if user opts out
                if (!UserWarning(entry, connection, nameSelected))
                {
                    return null;
                } else {
                    p = new DynamicParameters();
                    p.Add("name", entry.Name);

                    entry.id = SaveName(entry, connection);

                    if (entry.Name != nameSelected)
                    {
                        DeleteEntry(nameSelected, false);  // deletes old data that is being moved
                    }
                }

                p = new DynamicParameters();
                p.Add("street", entry.Address.Street);
                p.Add("city", entry.Address.City);
                p.Add("state", entry.Address.State);
                p.Add("zip", entry.Address.Zip);

                if (connection.Query<int>("dbo.spAddress_GetID", p, commandType: CommandType.StoredProcedure).ToList().Count != 0)  // if ID exists
                {
                    entry.Address.id = connection.Query<int>("dbo.spAddress_GetID", p, commandType: CommandType.StoredProcedure).First();
                } else
                {
                    entry.Address.id = SaveAddress(entry, connection);
                }

                ConnectPersonWithAddress(entry, connection);

                SavePhoneNumbers(entry, connection);



                return entry;
            }
        }

        /// <summary>
        /// Deletes any known records of phone numbers for entry, then adds the new phone numbers to the database.
        /// </summary>
        /// <param name="entry">Entry object with personID</param>
        /// <param name="connection">Connection method (SQL)</param>
        private void SavePhoneNumbers(EntryModel entry, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("personID", entry.id);
            connection.Execute("dbo.spPhone_Delete", p, commandType: CommandType.StoredProcedure);

            if (entry.PhoneNumbers != null)
            {
                foreach (PhoneNumberModel number in entry.PhoneNumbers)
                {
                    if (number.Description == "Home")
                    {
                        p.Add("phoneType", 1);
                    }
                    else if (number.Description == "Mobile")
                    {
                        p.Add("phoneType", 2);
                    }
                    else if (number.Description == "Work")
                    {
                        p.Add("phoneType", 3);
                    }
                    p.Add("phoneNumber", number.Number);
                    connection.Execute("dbo.spPhone_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        /// <summary>
        /// Saves data linking a Person to an Address in the PersonAddres table.
        /// </summary>
        /// <param name="entry">Entry object with IDs</param>
        /// <param name="connection">Connection method (SQL)</param>
        private void ConnectPersonWithAddress(EntryModel entry, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("personID", entry.id);
            p.Add("addressID", entry.Address.id);

            // Confirms that the address link is not already present
            if (connection.Query("dbo.spPersonAddress_GetRow", p, commandType: CommandType.StoredProcedure).ToArray().Length == 0)
            {
                connection.Execute("dbo.spPersonAddress_DeleteRow", p, commandType: CommandType.StoredProcedure);  // deletes any current address links
                connection.Execute("dbo.spPersonAddress_Insert", p, commandType: CommandType.StoredProcedure);  // adds new address link
            }
        }

        /// <summary>
        /// Saves address information to database table Address.
        /// </summary>
        /// <param name="entry">Entry object w/o address ID</param>
        /// <param name="connection">Connection method (SQL)</param>
        /// <returns>Address' ID from table</returns>
        private int SaveAddress(EntryModel entry, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("street", entry.Address.Street);
            p.Add("city", entry.Address.City);
            p.Add("state", entry.Address.State);
            p.Add("zip", entry.Address.Zip);
            p.Add("@addressID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spAddress_Insert", p, commandType: CommandType.StoredProcedure);
            return p.Get<int>("@addressID");
        }

        /// <summary>
        /// Warning box that appears if attempting to overwrite entry already present in database (duplicate name)
        /// </summary>
        /// <param name="entry">Entry object</param>
        /// <param name="connection">Connection method (SQL)</param>
        /// <param name="nameSelected">Name box from when EditForm loaded to determine if making a new entry or not.</param>
        /// <returns></returns>
        private bool UserWarning(EntryModel entry, IDbConnection connection, string nameSelected)
        {
            var p = new DynamicParameters();
            p.Add("@name", entry.Name);

            if (connection.Query<int>("dbo.spPerson_GetID", p, commandType: CommandType.StoredProcedure).ToList().Count != 0
                && entry.Name != nameSelected)  // if ID exists and we have changed the name of the person being edited
            {
                // Allow user to cancel overwriting data
                DialogResult choice = MessageBox.Show("Name already exists. Overwrite data?", "Duplicate Name", MessageBoxButtons.YesNo);
                if (choice == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Saves name to database table Person.
        /// </summary>
        /// <param name="entry">Entry object w/o person ID</param>
        /// <param name="connection">Connection method (SQL)</param>
        /// <returns>Person's ID from table</returns>
        private static int SaveName(EntryModel entry, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@name", entry.Name);
            if (connection.Query<int>("dbo.spPerson_GetID", p, commandType: CommandType.StoredProcedure).ToList().Count != 0)
            {
                return connection.Query<int>("dbo.spPerson_GetID", p, commandType: CommandType.StoredProcedure).First();
            } else
            {
                p.Add("@personID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);
                return p.Get<int>("@personID");
            }
        }

        /// <summary>
        /// Fetches all names from the database.
        /// </summary>
        /// <returns>List of strings</returns>
        public List<String> GetEntries(string filter)
        {
            List<String> output = new List<String>();
            var p = new DynamicParameters();
            p.Add("filter", filter);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                output = connection.Query<String>("dbo.spPerson_GetAll", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }


        /// <summary>
        /// Fetches address information of an entry.
        /// </summary>
        /// <param name="name">String name of person to fetch</param>
        /// <returns>Returns array of address information. If name not found, return null.</returns>
        public dynamic GetAddress(string name) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                var p = new DynamicParameters();
                p.Add("name", name);

                var output = connection.Query("dbo.spPerson_GetAddress", p, commandType: CommandType.StoredProcedure).ToArray();
                if (output.Length > 0) { return output[0]; } else { return null; }
            }
        }

        /// <summary>
        /// Fetches phone information of an entry.
        /// </summary>
        /// <param name="name">String name of person to fetch</param>
        /// <returns>Returns array of phone information. If name not found, return null.</returns>
        public dynamic GetPhoneNumbers(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                var p = new DynamicParameters();
                p.Add("name", name);

                var output = connection.Query("dbo.spPerson_GetPhoneNumbers", p, commandType: CommandType.StoredProcedure).ToArray();
                if (output.Length > 0) { return output; } else { return null; }
            }
        }

        /// <summary>
        /// Deletes user from database. Does not delete address information or phone information from the database.
        /// </summary>
        /// <param name="name">String name of person to delete</param>
        public void DeleteEntry(string name, bool confirmation)
        {
            if (confirmation)
            {
                DialogResult choice = MessageBox.Show("Delete entry for " + name + "?", "Delete User", MessageBoxButtons.YesNo);
                if (choice == DialogResult.No)
                {
                    return;
                }
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                var p = new DynamicParameters();
                p.Add("@name", name);

                connection.Execute("dbo.spPerson_DeleteName", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Method used to clear database of no-longer-relevant data.
        /// </summary>
        public void DeleteUnusedData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                connection.Execute("dbo.spAddress_DeleteUnused", commandType: CommandType.StoredProcedure);
            }
        }
    }
} 

using AddressBookLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Method that runs when Save button gets clicked. Inserts a name into the database and returns the ID the entry object with ID information.
        /// </summary>
        /// <param name="entry">Entry Object w/o ID</param>
        /// <returns>Entry Object w/ ID</returns>
        public EntryModel SaveEntry(EntryModel entry)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                var p = new DynamicParameters();
                p.Add("@name", entry.Name);
                p.Add("@personID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                entry.id = p.Get<int>("@personID");

                return entry;
            }
        }

        /// <summary>
        /// Fetches all names from the database.
        /// </summary>
        /// <returns>List of strings</returns>
        public List<String> GetEntries()
        {
            List<String> output = new List<String>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                output = connection.Query<String>("dbo.spPerson_GetAll").ToList();
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
                if (output.Length > 0) { return output[0]; } else {  return null; }
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
    }
}

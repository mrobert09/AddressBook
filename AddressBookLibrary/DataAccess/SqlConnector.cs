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

        public List<String> GetEntries()
        {
            List<String> output = new List<String>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                output = connection.Query<String>("dbo.spPerson_GetAll").ToList();
            }

            return output;
        }


        public dynamic GetAddress(string name) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("AddressBook")))
            {
                var p = new DynamicParameters();
                p.Add("name", name);

                var output = connection.Query("dbo.spPerson_GetAddress", p, commandType: CommandType.StoredProcedure).ToArray();
                if (output.Length > 0) { return output[0]; } else {  return null; }
            }
        }
    }
}

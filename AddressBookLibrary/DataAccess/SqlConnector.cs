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
    }
}

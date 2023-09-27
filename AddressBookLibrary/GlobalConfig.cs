using AddressBookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Creates the initial connector information. Currently only supports a database.
        /// </summary>
        /// <param name="database">True if using database, flase if not.</param>
        public static void InitializeConnections(bool database)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }

        /// <summary>
        /// Fetches the connection string information.
        /// </summary>
        /// <param name="name">String name of database.</param>
        /// <returns>String</returns>
        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

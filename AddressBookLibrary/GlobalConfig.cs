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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

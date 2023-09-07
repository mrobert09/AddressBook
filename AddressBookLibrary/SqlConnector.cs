using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary
{
    public class SqlConnector : IDataConnection
    {
        public EntryModel SaveEntry(EntryModel entry)
        {
            entry.id = 1;

            return entry;
        }
    }
}

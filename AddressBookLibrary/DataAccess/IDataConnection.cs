using AddressBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.DataAccess
{
    /// <summary>
    /// Interface for any data connections that might exist.
    /// </summary>
    public interface IDataConnection
    {
        EntryModel SaveEntry(EntryModel entry, string currentEntry);

        List<String> GetEntries();

        dynamic GetAddress(string name);

        dynamic GetPhoneNumbers(string name);

        void DeleteEntry(string name);
    }
}

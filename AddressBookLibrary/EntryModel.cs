using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary
{
    public class EntryModel
    {
        /// <summary>
        /// Unique identifier of the entry.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Represents who this address entry belongs to.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of all addresses associated with this entry.
        /// </summary>
        public AddressModel Address { get; set; } = new AddressModel();

        /// <summary>
        /// A list of all phone numbers associated with this entry.
        /// </summary>
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    }
}

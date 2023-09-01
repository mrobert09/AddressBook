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
        /// Represents who this address entry belongs to.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of all addresses associated with this entry.
        /// </summary>
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

        /// <summary>
        /// A list of all phone numbers associated with this entry.
        /// </summary>
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.Models
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

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public EntryModel()
        {

        }

        /// <summary>
        /// Constructor with provided parameters.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="address">AddressModel</param>
        /// <param name="phoneNumbers">List<PhoneNumberModel></param>
        public EntryModel(string name, AddressModel address, List<PhoneNumberModel> phoneNumbers)
        {
            Name = name;
            Address = address;
            PhoneNumbers = phoneNumbers;
        }
    }
}

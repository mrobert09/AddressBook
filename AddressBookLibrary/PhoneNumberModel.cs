using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary
{
    public class PhoneNumberModel
    {
        /// <summary>
        /// Constructor for PhoneNumberModel.
        /// </summary>
        /// <param name="description">String</param>
        /// <param name="number">String</param>
        public PhoneNumberModel(string description, string number) {
            Description = description;
            Number = number;
        }

        /// <summary>
        /// Represents a description of the phone number such as "Home" or "Mobile".
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Represents a phone number in string format.
        /// </summary>
        public string Number { get; set; }
    }
}

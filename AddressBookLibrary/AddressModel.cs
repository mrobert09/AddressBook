using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary
{
    public class AddressModel
    {
        /// <summary>
        /// Constructor for AddressModel.
        /// </summary>
        public AddressModel(string street, string city, string state, string zip, string description = null) {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Description = description;
        }

        /// <summary>
        /// Represents a street address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Represents a city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Represents a state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Represents the zip code in string format.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Represents an optional description of the address.
        /// </summary>
        public string Description { get; set; }
    }
}

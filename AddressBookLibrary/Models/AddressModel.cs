using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.Models
{
    public class AddressModel
    {
        private string street;
        private string city;
        private string state;
        private string zip;

        /// <summary>
        /// Unique identifier of the entry.
        /// </summary>
        public int id { get; set; }

        public AddressModel()
        {
        }

        /// <summary>
        /// Constructor for AddressModel.
        /// </summary>
        public AddressModel(string street, string city, string state, string zip) {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        /// <summary>
        /// Represents a street address.
        /// </summary>
        public string Street {
            get { return street; } 
            set
            {
                if (value.Length <= 0) {
                    street = null;
                }
                else
                {
                    street = value;
                }
            } 
        }

        /// <summary>
        /// Represents a city.
        /// </summary>
        public string City {
            get { return city; }
            set
            {
                if (value.Length <= 0)
                {
                    city = null;
                }
                else
                {
                    city = value;
                }
            }
        }

        /// <summary>
        /// Represents a state.
        /// </summary>
        public string State {
            get { return state; }
            set
            {
                if (value.Length <= 0)
                {
                    state = null;
                }
                else
                {
                    state = value;
                }
            }
        }

        /// <summary>
        /// Represents the zip code in string format.
        /// </summary>
        public string Zip {
            get { return zip; }
            set
            {
                if (value.Length <= 0)
                {
                    zip = null;
                }
                else
                {
                    zip = value;
                }
            }
        }
    }
}

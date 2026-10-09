using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    /// <summary>
    /// Represents an address that includes a street, postal code and a city.
    /// </summary>
    internal class Address
    {
        public string Street { get; private set; }

        public string Zipcode { get; private set; }

        public string City { get; private set; }

        


        /// <summary>
        /// Creates an Address with a street, postal code and a city.
        /// </summary>
        /// <param name="street">Street name and number.</param>
        /// <param name="zipcode">The address postal code.</param>
        /// <param name="city">The city where the address is located.</param>
        public Address(string street, string zipcode, string city)
        {
            Street = street;
            Zipcode = zipcode;
            City = city;
        }
    }
}

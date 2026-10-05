using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class Address
    {
        public string Street { get; private set; }

        public string PostalCode { get; private set; }

        public string City { get; private set; }
        public Address(string street, string postalCode, string city)
        {
            Street = street;
            PostalCode = postalCode;
            City = city;
        }
    }
}

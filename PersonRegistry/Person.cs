using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PersonRegistry
{
    /// <summary>
    /// Representing a person, That needs a Id, Name, Email, Address and a Company
    /// </summary>
    internal class Person
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Address Address { get; private set; }

        public Company Company { get; private set; }


        /// <summary>
        /// Creates a Person object with the specified values.
        /// </summary>
        /// <param name="id">Identifier number for the person.</param>
        /// <param name="name">The person's full name.</param>
        /// <param name="email">The person's email address.</param>
        /// <param name="address">The person's home address (street, postal code and city).</param>
        /// <param name="company">The person's workplace.</param>
        public Person(int id, string name, string email, Address address, Company company)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Company = company;
        }
    }
}

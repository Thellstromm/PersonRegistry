using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PersonRegistry
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }

        public Company Company { get; set; }

        public Person(int id string name string email Address address Company company)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Company = company;
        }
    }
}

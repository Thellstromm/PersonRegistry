using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class Company
    {
        public string Name { get; private set; }

        public string Slogan { get; private set; }

        public Company(string name, string slogan)
        {
            Name = name;
            Slogan = slogan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    /// <summary>
    /// Representing a company with a name and there slogan
    /// </summary>
    internal class Company
    {
        public string Name { get; private set; }

        public string CatchPhrase { get; private set; }

        

        /// <summary>
        /// Creates a company with a name and a slogan
        /// </summary>
        /// <param name="name">Name of the company</param>
        /// <param name="catchPhrase">The companys slogan</param>
        public Company(string name, string catchPhrase)
        {
            Name = name;
            CatchPhrase = catchPhrase;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class PersonService
    {
        private PersonDataStore _personDataStore;

        public PersonService(PersonDataStore personDataStore)
        {
            _personDataStore = personDataStore;
        }

        public List<Person> GetAllSortedById()
        {

        }
        public List<Person> GetTop5SortedById()
        {

        }
        public List<Person> GetAllSortedByName()
        {

        }
        public List<Person> GetTop5SortedByName()
        {

        }
        public List<Person> SearchByName(string searchText)
        {

        }
    }
}

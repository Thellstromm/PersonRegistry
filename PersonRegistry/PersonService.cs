using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PersonRegistry
{
    /// <summary>
    /// Includes methods that can sort and handle lists of the type Person
    /// </summary>
    internal class PersonService
    {
        private IPersonDataStore _personDataStore;

        public PersonService(IPersonDataStore personDataStore)
        {
            _personDataStore = personDataStore;
        }

        public List<Person> GetAllSortedById()
        {
            List<Person> people = _personDataStore.GetPeople();
            var sorted = people.OrderBy(person => person.Id).ToList();
            return sorted;

        }

        public List<Person> GetTop5SortedById()
        {
            List<Person> people = GetAllSortedById();
            List<Person> top5ById = people.Take(5).ToList();
            return top5ById;
        }

        public List<Person> GetAllSortedByName()
        {
            List<Person> people = _personDataStore.GetPeople();
            var sorted = people.OrderBy(person => person.Name).ToList();
            return sorted;
        }

        public List<Person> GetTop5SortedByName()
        {
            List<Person> people = GetAllSortedByName();
            List<Person> top5ByName = people.Take(5).ToList();
            return top5ByName;
        }

        public List<Person> SearchByName(string searchText)
        {
            List<Person> people = _personDataStore.GetPeople();
            var match = people.Where(person => person.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).OrderBy(person => person.Id).ToList();
            return match;

        }
    }
}

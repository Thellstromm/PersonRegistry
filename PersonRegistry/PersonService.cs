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
        private PersonDataStore _personDataStore;

        public PersonService(PersonDataStore personDataStore)
        {
            _personDataStore = personDataStore;
        }

        /// <summary>
        /// Works as a rule to use in Lists Sort() method, so it can sort by ther Persons Id
        /// </summary>
        private static int CompareById(Person a, Person b)
        {
            return a.Id.CompareTo(b.Id);
        }

        public List<Person> GetAllSortedById()
        {
            List<Person> people = _personDataStore.GetPeople();
            List<Person> sorted = new List<Person>(people); // Copy list because list ís a refrence type (even though the method GetPeople() always makes a new list, so its not neccesary here even tho its good practice to do so)
            sorted.Sort(CompareById);
            return sorted;

        }
        public List<Person> GetTop5SortedById()
        {
            List<Person> people = GetAllSortedById();
            List<Person> top5ById = new List<Person>();

            int count = Math.Min(5, people.Count); // If the list is less than 5 it makes sure the loop only loops for how long the list is. 
            for(int i = 0; i < count; i++)
            {
                top5ById.Add(people[i]);
            }
            return top5ById;
        }
        /// <summary>
        /// Works as a rule to use in Lists Sort() method, so it can sort by ther Persons name
        /// </summary>
        private static int CompareByName(Person a, Person b)
        {
            return a.Name.CompareTo(b.Name);
        }
        public List<Person> GetAllSortedByName()
        {
            List<Person> people = _personDataStore.GetPeople();
            List<Person> sorted = new List<Person>(people); // Copy list because list ís a refrence type (even though the method GetPeople() always makes a new list, so its not neccesary here even tho its good practice to do so)
            sorted.Sort(CompareByName);
            return sorted;
        }
        public List<Person> GetTop5SortedByName()
        {
            List<Person> people = GetAllSortedByName();
            List<Person> top5ByName = new List<Person>();

            int count = Math.Min(5, people.Count); // If the list is less than 5 it makes sure the loop only loops for how long the list is. 
            for (int i = 0; i < count; i++)
            {
                top5ByName.Add(people[i]);
            }
            return top5ByName;
        }
        public List<Person> SearchByName(string searchText)
        {
            List<Person> people = _personDataStore.GetPeople();
            List<Person> match = new List<Person>();
        

            foreach (Person person in people)
            {
                if (person.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    match.Add(person);
                }
            }

            match.Sort(CompareById);
            return match;

        }
    }
}

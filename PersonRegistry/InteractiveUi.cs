using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class InteractiveUi
    {

        private readonly PersonService _service;
        public InteractiveUi(PersonService service)
        {
            _service = service;
        }
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public string ReadInput()
        {
            string input = Console.ReadLine() ?? "";
            return input;
        }

        public void ShowMenu()
        {
            DisplayText("Person Registry");
            DisplayText("-----------------");
            DisplayText("1: Show all persons (sorted by ID)");
            DisplayText("2: Show the first 5 persons (sorted by ID)");
            DisplayText("3: Show all persons (sorted by name)");
            DisplayText("4: Show the first 5 persons (sorted by name)");
            DisplayText("5: Search for a person by name");
            DisplayText("Q: Quit");
            DisplayText("");
            DisplayText("Choose an option (1-6 or Q to quit):");
        }

        public void DisplayPersonList(List<Person> people)
        {
            foreach (Person person in people)
            {

                DisplayText($"ID: {person.Id}\n" +
                    $"Name: {person.Name}\n" +
                    $"Email: {person.Email}\n" +
                    $"Address: {person.Address.Street}, {person.Address.PostalCode} {person.Address.City}\n" +
                    $"Company: {person.Company.Name} - {person.Company.Slogan}" +
                    $"\n------------------------------------------------------------");
            }
        }
        public void Run()
        {

        }


    }
}

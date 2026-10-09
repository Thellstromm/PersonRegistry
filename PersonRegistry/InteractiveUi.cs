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
        private void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        private void PressKey()
        {
            Console.ReadKey();
        }

        private string ReadInput()
        {
            string input = Console.ReadLine() ?? "";
            return input;
        }

        private void ShowMenu()
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
            DisplayText("Choose an option (1-5 or Q to quit):");
        }

        private void DisplayPersonList(List<Person> people)
        {
            if (people.Count == 0)
            {
                DisplayText("No results found");
            }
            else
            {
                DisplayText("");
                foreach (Person person in people)
                {
                    DisplayPerson(person);
                }
            }
        }

        private void DisplayPerson(Person person)
        {
            DisplayText($"ID: {person.Id}\n" +
                    $"Name: {person.Name}\n" +
                    $"Email: {person.Email}\n" +
                    $"Address: {person.Address.Street}, {person.Address.Zipcode} {person.Address.City}\n" +
                    $"Company: {person.Company.Name} - {person.Company.CatchPhrase}" +
                    $"\n------------------------------------------------------------");
        }

        private void ShowAllSortedById()
        {
            List<Person> sortedId = _service.GetAllSortedById();
            DisplayPersonList(sortedId);
            DisplayText("Press any key to continue...");
            PressKey();
            ShowMenu();
        }
        private void ShowTop5SortedById()
        {
            List<Person> sortedTop5Id = _service.GetTop5SortedById();
            DisplayPersonList(sortedTop5Id);
            DisplayText("Press any key to continue...");
            PressKey();
            ShowMenu();
        }
        private void ShowAllSortedByName()
        {
            List<Person> sortedName = _service.GetAllSortedByName();
            DisplayPersonList(sortedName);
            DisplayText("Press any key to continue...");
            PressKey();
            ShowMenu();
        }
        private void ShowTop5SortedByName()
        {
            List<Person> sortedTop5Name = _service.GetTop5SortedByName();
            DisplayPersonList(sortedTop5Name);
            DisplayText("Press any key to continue...");
            PressKey();
            ShowMenu();
        }

        private void ShowSearchByName()
        {
            DisplayText("------------------------------------------------------------");
            DisplayText("Search for Person: ");
            string search = ReadInput();
            List<Person> SearchedByName = _service.SearchByName(search);
            DisplayPersonList(SearchedByName);
            DisplayText("Press any key to continue...");
            PressKey();
            ShowMenu();
        }
        public void Run()
        {
            bool run = true;

            ShowMenu();

            while (run)
            {

                string input = ReadInput();

                switch (input)
                {
                    case "1":
                        ShowAllSortedById();
                        break;

                    case "2":
                        ShowTop5SortedById();
                        break;

                    case "3":
                        ShowAllSortedByName();
                        break;

                    case "4":
                        ShowTop5SortedByName();
                        break;

                    case "5":
                        ShowSearchByName();
                        break;
                    case "q":
                    case "Q":
                        run = false;
                        break;

                    default:
                        DisplayText("Invalid input. Please enter a valid option: ");
                        break;
                }
            }



        }


    }
}

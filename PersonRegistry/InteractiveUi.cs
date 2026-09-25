using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class InteractiveUi
    {
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
        public void Run()
        {

        }


    }
}

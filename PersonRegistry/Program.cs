

namespace PersonRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI → Service → DataStore → Models

            if (args.Length == 0)
            {

                IPersonDataStore storage = ChooseDataStorage();

                PersonService service = new PersonService(storage);
                InteractiveUi ui = new InteractiveUi(service);

                ui.Run();
            }

            else
            {

                IPersonDataStore storage = new PersonDataStore();
                PersonService service = new PersonService(storage);
                InteractiveUi ui = new InteractiveUi(service);
                if (args.Length == 3 &&
                    args[0] == "list" &&
                    args[1] == "--sort" &&
                    args[2] == "--top5")
                {
                    ui.ShowTop5SortedByName();
                }
                else if (args.Length == 2 &&
                         args[0] == "list" &&
                         args[1] == "--sort")
                {
                    ui.ShowAllSortedByName();
                }
                else if (args.Length == 2 &&
                         args[0] == "list" &&
                         args[1] == "--top5")
                {
                    ui.ShowTop5SortedById();
                }
                else if (args.Length == 1 && args[0] == "list")
                {
                    ui.ShowAllSortedById();
                }
                else
                {
                    Console.WriteLine("Invalid command or argument.");
                }
            }
        }

        private static IPersonDataStore ChooseDataStorage()
        {
            IPersonDataStore storage;

            Console.WriteLine("Chosse DataStorage:\n" +
                "1. Hardcoded\n" +
                "2. JsonDatastore\n" +
                "(Chosse 1 or 2)");
            while (true)
            {
                string input = Console.ReadLine() ?? "";
                if (input == "1")
                {
                    storage = new PersonDataStore();
                    return storage;
                }
                else if (input == "2")
                {
                    storage = new JsonPersonDataStore();
                    return storage;
                }
                else
                {
                    Console.WriteLine("Inavlid input. Please try again:");
                }
            }
        }
    }
}

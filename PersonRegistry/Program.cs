

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
                RunWithArgs(args);
            }
        }


        private static IPersonDataStore ChooseDataStorage()
        {
            IPersonDataStore storage;

            Console.WriteLine("Choose data storage:\n" +
                              "1. Hardcoded\n" +
                              "2. JSON datastore\n" +
                              "(Choose 1 or 2)");
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
                    Console.WriteLine("Invalid input. Please try again:");
                }
            }
        }
        private static void RunWithArgs(string[] args)
        {
            IPersonDataStore storage;

            if (args.Contains("--useAltSource"))
            {
                storage = new JsonPersonDataStore();
                args = args.Where(arg => arg != "--useAltSource").ToArray();
            }
            else
            {
                storage = new PersonDataStore();
            }

            PersonService service = new PersonService(storage);
            InteractiveUi ui = new InteractiveUi(service);

            switch (args)
            {
                case ["list", "--sort", "--top5"]:
                    ui.ShowTop5SortedByName();
                    break;

                case ["list", "--search", var search]:
                    if (string.IsNullOrWhiteSpace(search))
                    {
                        Console.WriteLine("Search text cannot be empty");
                    }
                    else
                    {
                        ui.ShowSearchByName(search);
                    }
                    break;

                case ["list", "--sort"]:
                    ui.ShowAllSortedByName();
                    break;

                case ["list", "--top5"]:
                    ui.ShowTop5SortedById();
                    break;

                case ["list"]:
                    ui.ShowAllSortedById();
                    break;

                default:
                    Console.WriteLine("Invalid command or argument.");
                    break;
            }
        }
    }
}
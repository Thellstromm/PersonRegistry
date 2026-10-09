

namespace PersonRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI → Service → DataStore → Models

            IPersonDataStore storage = ChooseDataStorage();

            PersonService service = new PersonService(storage);
            InteractiveUi ui = new InteractiveUi(service);

            ui.Run();
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

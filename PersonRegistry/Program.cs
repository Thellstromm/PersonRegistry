

namespace PersonRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI → Service → DataStore → Models

            IPersonDataStore storage = new JsonPersonDataStore();
            PersonService service = new PersonService(storage);
            InteractiveUi ui = new InteractiveUi(service);

            ui.Run(); 
        }
    }
}

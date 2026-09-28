namespace PersonRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI → Service → DataStore → Modeller

            PersonDataStore storage = new PersonDataStore();
            PersonService service = new PersonService(storage);
            InteractiveUi ui = new InteractiveUi(service);

            ui.Run(); 
        }
    }
}

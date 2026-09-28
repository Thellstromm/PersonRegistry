namespace PersonRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI → Service → DataStore → Modeller


            var ui = new InteractiveUi();
            ui.ShowMenu();
        }
    }
}

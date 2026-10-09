

using System.Text.Json;

namespace PersonRegistry
{
    internal class JsonPersonDataStore : IPersonDataStore
    {
        public List<Person> GetPeople()
        {
            string json = File.ReadAllText("JsonDataStore.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            List<Person>? people = JsonSerializer.Deserialize<List<Person>>(json, options);

            if (people is not null)
            {
                return people;
            }
            else
            {
                return new List<Person>();
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegistry
{
    internal class PersonDataStore
    {
        public List<Person> GetPeople()
        {
            Company company1 = new Company("Nordic Tech AB", "Building the future, one line at a time.");
            Company company2 = new Company("GreenEnergy Solutions", "Powering tomorrow, sustainably.");
            Company company3 = new Company("DataFlow Systems", "Where data meets insight.");
            Company company4 = new Company("CloudNine Services", "Your business, elevated.");
            Company company5 = new Company("SecureNet AB", "Safety in every connection.");
            Company company6 = new Company("Innovate Labs", "Ideas into reality.");
            Company company7 = new Company("Urban Design Group", "Shaping the cities of tomorrow.");

            Address address1 = new Address("Storgatan 12", "11455", "Stockholm");
            Address address2 = new Address("Kyrkogatan 3", "41115", "Göteborg");
            Address address3 = new Address("Lilla Torg 7", "21134", "Malmö");
            Address address4 = new Address("Drottninggatan 45", "70223", "Örebro");
            Address address5 = new Address("Stora Nygatan 9", "58220", "Linköping");
            Address address6 = new Address("Vasagatan 22", "90326", "Umeå");
            Address address7 = new Address("Kungsgatan 18", "75321", "Uppsala");
            Address address8 = new Address("Hamngatan 5", "55312", "Jönköping");
            Address address9 = new Address("Strandvägen 31", "11456", "Stockholm");
            Address address10 = new Address("Esplanaden 14", "65223", "Karlstad");

            List<Person> people = new List<Person>();

            people.Add(new Person(305, "Anna Berg", "anna.berg@gmail.com", address1, company1));
            people.Add(new Person(102, "Johan Lind", "johan.lind@greenenergy.se", address2, company2));
            people.Add(new Person(417, "Maria Karlsson", "maria.karlsson@nordictech.se", address3, company1));
            people.Add(new Person(209, "Erik Johansson", "erik.j@dataflow.io", address4, company3));
            people.Add(new Person(511, "Sofia Andersson", "sofia.a@cloudnine.com", address5, company4));
            people.Add(new Person(128, "Anders Nilsson", "anders.nilsson@securenet.se", address6, company5));
            people.Add(new Person(376, "Emma Persson", "emma.persson@gmail.com", address7, company2));
            people.Add(new Person(243, "Lars Svensson", "lars.s@innovatelabs.com", address8, company6));
            people.Add(new Person(601, "Karin Eriksson", "karin.eriksson@urbandesign.se", address9, company7));
            people.Add(new Person(154, "Per Larsson", "per.larsson@hotmail.com", address10, company3));

            return people;
        }
    }
}

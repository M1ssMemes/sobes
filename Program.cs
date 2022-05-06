using System;
using System.Collections.Generic;
using System.Linq;

namespace sobes
{
    class Program
    {
        static void Main(string[] args)
        {

            var citizens = new List<Citizen>();


            var citizenA = new Citizen("John", "Smith", "Ivanov", new DateTime(1999, 4, 4), "Lerm street", "Moscow");
            citizens.Add(citizenA);

            var citizenB = new Citizen("Kevin", "Peris", "Semenov", new DateTime(2017, 4, 4), "Lenin street", "Moscow");
            citizens.Add(citizenB);

            var citizenC = new Citizen("Sam", "Smith", "Ivanov", new DateTime(1996, 4, 4), "Father street", "Paris");
            citizens.Add(citizenC);

            var citizenD = new Citizen("Mark", "Kelov", "Mikhailov", new DateTime(1990, 4, 4), "Kirman street",
                "Moscow");
            citizens.Add(citizenD);

            var citizenE = new Citizen("John", "Black", "Ivanov", new DateTime(2005, 4, 4), "Lerm street",
                "Los-Angeles");
            citizens.Add(citizenE);

            var citizenF = new Citizen("Mikhail", "Smith", "Mikhailov", new DateTime(2004, 4, 24), "Lerm street",
                "Paris");
            citizens.Add(citizenF);

            var citizenG = new Citizen("Livon", "Smith", "Ivanov", new DateTime(1999, 4, 4), "Lenin street", "Moscow");
            citizens.Add(citizenG);

            var citizenH = new Citizen("John", "Filler", "Mikhailov", new DateTime(1998, 4, 4), "Vasman street",
                "Los-Angeles");
            citizens.Add(citizenH);

            var citizenI = new Citizen("Ivan", "Carry", "Ivanov", new DateTime(2000, 4, 4), "Break avenue", "Oslo");
            citizens.Add(citizenI);

            var citizenJ = new Citizen("Genry", "Smith", "Ivanov", new DateTime(2011, 4, 4), "Lerm street", "Moscow");
            citizens.Add(citizenJ);

            var citizenK = new Citizen("Piter", "Smith", "Ivanov", new DateTime(1990, 4, 4), "Central street", "Oslo");
            citizens.Add(citizenK);

            var citizenN = new Citizen("John", "Potter", "Ivanov", new DateTime(1991, 4, 4), "North street", "Moscow");
            citizens.Add(citizenN);

            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Ordered by day of birth:");


            foreach (var citizen in citizens.OrderBy(person => person.Dayofbirth))
            {
                Console.WriteLine(citizen);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Adult citizens only:");

            foreach (var citizen in citizens.Where(person => (DateTime.Now.Year - person.Dayofbirth.Year) >= 18))
            {
                Console.WriteLine(citizen);
            }

            Console.WriteLine("Enter city for search:");

            var city = Console.ReadLine();

            if (city == null)
            {
                Console.WriteLine("Expected city name, got nothing");
            }

            var citizenship = citizens.Where(person => person.City.ToLower() == city.ToLower()).ToList();

            if (!citizenship.Any())
                Console.WriteLine("No data found");
            else
            {
                Console.WriteLine($"Citizens in {city}: \n");
                foreach (var citizen in citizenship)
                {

                    Console.WriteLine(citizen);
                }
            }

            Console.WriteLine();
        }
    }
}

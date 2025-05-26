using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            Person p1 = new Person();
            p1.PersonID = 1;
            p1.Name = "Elham";
            p1.Family = "Razmjooy";
            p1.Age = 27;
            People.Add(p1);

            Person p2 = new Person() { PersonID = 2, Name = "Iman", Family = "Madaeny", Age = 30 };
            People.Add(p2);

            People.Add(new Person() { PersonID = 3, Name = "Ali", Family = "Ahmadi", Age = 42 });

            var result1 = People.OrderByDescending(p => p.Age).ToList();

            var result2 = People.Select(P => P.Name).ToList();

            var result3 = People.Select(p => new { p.Name, p.Family }).ToList();

            foreach (var p in result1)
            {
                Console.WriteLine($"ID: {p.PersonID} Name: {p.Name} Family: {p.Family} Age: {p.Age}");
            }

            List<PersonCar> Cars = new List<PersonCar>()
            {
                new PersonCar() {PersonID = 1,CarName = "Pride",CarModel = "1386" },
                new PersonCar() {PersonID = 3,CarName = "Paykan",CarModel = "1364"}
            };
            var join = (from p in People
                        join c in Cars on p.PersonID equals c.PersonID
                        select new
                        { p.PersonID,
                          p.Name,
                          p.Family,
                          p.Age,
                          c.CarName,
                          c.CarModel
                        }).ToList();
        }
    }
}

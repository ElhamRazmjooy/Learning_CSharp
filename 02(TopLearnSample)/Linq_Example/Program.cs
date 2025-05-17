using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linq_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31 };
            int[] result1 = (from n in numbers select n).ToArray();
            var lambda1 = numbers.ToArray();

            int[] result2 = (from n in numbers
                             orderby n descending
                             select n).ToArray();
            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            int[] result3 = (from n in numbers
                             where n > 10 && n < 30
                             orderby n descending
                             select n).ToArray();
            var lambda3 = numbers.Where(n => n > 10 && n < 30).OrderByDescending(n => n).ToArray();

            int result4 = (from n in numbers
                           where n == 3
                           select n).First();
            var lambda4 = numbers.Where(n => n == 3).First();

            int result5 = (from n in numbers
                           where n == 4
                           select n).FirstOrDefault();
            var lambda5= numbers.Where(n => n == 4).FirstOrDefault();

            int result6 = (from n in numbers
                           where n == 21
                           select n).Single();
            var lambda6 = numbers.Where(n => n == 21).Single();

            int result7 = (from n in numbers
                           where n == 22
                           select n).SingleOrDefault();
            var lamda7 = numbers.Where(n => n == 22).SingleOrDefault();

            var i1 = 125;
            var i2 = "Elham";

            bool result8 = (from n in numbers
                            where n == 3
                            select n).Any();
            var lambda8 = numbers.Where(n=> n==3).Any();

            bool result9 = (from n in numbers
                            where n == 14
                            select n).Any();
            var lambda9 = numbers.Where(n => n == 14).Any();
            int Count = (from n in numbers
                         select n).Count();
            var Count1 = numbers.Count();

            int Count2 = (from n in numbers
                          where n > 10 && n < 30
                          select n).Count();
            var Count3 = numbers.Where(n => n > 10 && n < 30).Count();

            int Max = (from n in numbers select n).Max();
            var Max1 = numbers.Max();

            int Max2 = (from n in numbers
                        where n > 1 && n < 10
                        select n).Max();
            var Max3 = numbers.Where(n=> n > 1 && n < 10).Max();

            int Min = (from n in numbers select n).Min();
            var Min1 = numbers.Min();

            int Min2 = (from n in numbers
                        where n > 11 && n < 27
                        select n).Min();
            var Min3 = numbers.Where(n=> n > 11 && n < 27).Min();

            int Sum = (from n in numbers select n).Sum();
            var Sum1 = numbers.Sum();

            int Sum2 = (from n in numbers
                        where n > 10 && n < 30
                        select n).Sum();
            var Sum3 = numbers.Where(n=> n > 10 && n < 30).Sum();

            List<string> Names = new List<string>();
            Names.Add("Elham");
            Names.Add("Zahra");
            Names.Add("Fatemeh");
            Names.Add("Hanieh");
            var res1 = (from n in Names select n).ToList();
            var Lambda1 =Names.ToList();
            var res2 = (from n in Names
                        where n.Contains("e")
                        select n).ToList();
            var Lambda2 = Names.Where(n => n.Contains("e")).ToList();

            var res3 = (from n in Names
                        where n.ToLower().Contains("e")
                        select n).ToList();
            var Lambda3 =Names.Where(n=> n.ToLower().Contains("e")).ToList();

            var res4 = (from n in Names
                        where n.ToLower().StartsWith("h")
                        select n).ToList();
            var Lambda4 = Names.Where(n=> n.ToLower().StartsWith("h")).ToList();

            var res5 = (from n in Names
                        where n.EndsWith("h")
                        select n).ToList();
            var Lambda5 = Names.Where(n=> n.EndsWith("h")).ToList();
          
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result10 = (from n in Numbers
                            where n % 2 == 0
                            select n).ToList();
            var lambda10 = Numbers.Where(n => n % 2 == 0).ToList();

            var result11 = (from n in Numbers
                            where n % 2 != 0
                            select n).ToList();
            var lambda11 = Numbers.Where(n => n % 2 != 0).ToList();

            List<string> Names1 = new List<string> { "Ali", "Sara", "Amir", "Reza", "Ava" };
            var res6 = (from n in Names1
                        where n.ToLower().StartsWith("a")
                        select n).ToList();
            var Lambda6 = Names1.Where(n => n.ToLower().StartsWith("a")).ToList();
            
            List<int> Numbers1 = new List<int> { 1, 6, 3, 9, 2, 7 };
            var res7 = (from n in Numbers1
                        where n > 5
                        select n).Sum();
            var Lambda7 = Numbers1.Where(n => n > 5).Sum();

            List<string> Fruits = new List<string> { "Banana", "Apple", "Kiwi", "Watermelon" };
            var res8 = (from n in Fruits
                        orderby n.Length ascending
                        select n).ToList();
            var Lambda8 = Fruits.OrderBy(n => n.Length ).ToList();

            var People = new List<(string Name, int Age)>
            {("Ali", 25),("Sara", 30),("Reza", 25),("Maryam", 30),("Amir", 20)};
            var groupedPeople = (from name in People
                                 where name.Age < 25 || name.Age == 25 || name.Age == 30
                                 group name by name.Age into ageGroup
                                 select ageGroup).ToList();
            var groupedPeople1 = People.Where(n => n.Age<=30).GroupBy(n => n.Age).ToList();


            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var name in group)
                {
                    Console.WriteLine($" {name.Name}");
                }
            }

            List<string> cities = new List<string> { "Tehran", "Shiraz", "Qom", "Yazd", "Tabriz", "Rasht" };
            var res9 = (from name in cities
                          where name.Length > 4
                          select name).ToList();
            var Lambda9 = cities.Where(n => n.Length > 4).ToList();

            List<int> Numbers2 = new List<int> { 1, 4, 5, 6, 7, 9, 10 };
            var res10 = (from n in Numbers2
                         where n % 2 != 0
                         select n * 3).ToList();
            var Lamda10 = Numbers2.Where(n => n % 2 != 0).Select(n => n * 3).ToList();

            var res11 = (from n in Numbers2
                         where n % 2 == 0
                         select n * 2).ToList();
            var Lambda11 = Numbers2.Where(n => n % 2 == 0).Select(n => n * 2).ToList();

            int[] Numbers3 = { 1, 1, 2, 3, 4, 9, 10, 15, 15, 20, 25 };
            var res12 = Numbers3.Distinct().ToArray();
            var res13 = Numbers3.OrderByDescending(n => n).Take(3).ToArray();
            var res14 = Numbers3.OrderByDescending(n => n).Skip(3).ToArray();
            var res15 = Numbers3.OrderByDescending(n => n).Skip(3).Take(3).ToArray();
        }

    }
}

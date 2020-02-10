using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();

                try
                {
                    string firstName = input[0];
                    string lastName = input[1];
                    int age = int.Parse(input[2]);
                    decimal salary = decimal.Parse(input[3]);

                    var person = new Person(firstName, lastName, age, salary);
                    people.Add(person);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var sortedPeopleList = people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

            var percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in sortedPeopleList)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person.ToString());
            }
        }
    }
}

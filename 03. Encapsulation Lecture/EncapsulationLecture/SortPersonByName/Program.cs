using System;
using System.Collections.Generic;
using System.Linq;

namespace SortPersonByName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);

                var person = new Person(firstName, lastName, age, salary);

                people.Add(person);
            }

            var sortedPeopleList = people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

            //Console.WriteLine(string.Join(Environment.NewLine, sortedPeopleList));

            var percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in sortedPeopleList)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person.ToString());
            }

            //people.ForEach(p => p.IncreaseSalary(percentage));
            //people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

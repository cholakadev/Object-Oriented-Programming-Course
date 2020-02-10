using System;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            animals.Add(new Animal());
            animals.Add(new Mammal());
            animals.Add(new Person());
            animals.Add(new Dog());
            animals.Add(new Cat());


            foreach (Animal creature in animals)
            {
                creature.Sound();
            }
        }
    }
}

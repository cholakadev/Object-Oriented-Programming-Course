using System;

namespace SingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gosho";
            CharactersList characters = new CharactersList();

            characters.Add(new Hero("Player1", 100, 5, 10));
            characters.Add(new Hero("Player2", 200, 10, 20));

            characters.Add(new Monster("Monster1", 100, 20));
            characters.Add(new Monster("Monster2", 200, 40));

            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }
        }
    }
}

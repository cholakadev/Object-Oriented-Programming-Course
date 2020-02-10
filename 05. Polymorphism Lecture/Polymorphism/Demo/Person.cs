namespace Demo
{
    using System;
    public class Person : Animal
    {
        public int Salary => 1000;

        public override void Sound()
        {
            Console.WriteLine($"I am a person with {this.Salary} salary.");
        }
    }
}

using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine()
                .Split()[1];

                string[] doughInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                string flourType = doughInput[1];
                string bakingTechnique = doughInput[2];
                double weight = double.Parse(doughInput[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] inputTopping = command
                        .Split()
                        .ToArray();

                    string toppingProduct = inputTopping[1];
                    double weightOfTopping = double.Parse(inputTopping[2]);

                    Topping topping = new Topping(toppingProduct, weightOfTopping);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.PizzaTotalCalories:F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

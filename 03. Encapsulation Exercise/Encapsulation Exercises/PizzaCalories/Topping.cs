namespace PizzaCalories
{
    using System;
    public class Topping
    {
        private string toppingProduct;
        private double weight;
        public Topping(string toppingProduct, double weight)
        {
            this.ToppingProduct = toppingProduct;
            this.Weight = weight;
        }

        public string ToppingProduct
        {
            get
            {
                return toppingProduct;
            }
            private set
            {
                if (!ToppingValidator.isValidToppingType(value))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                toppingProduct = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.ToppingProduct} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }

        public double ToppingTotalCalories()
        {
            return 2 * this.Weight * ToppingValidator.GetToppingModifier(this.ToppingProduct);
        }
    }
}

namespace PizzaCalories
{
    using System;
    public class Dough
    {
        private string flourType;
        private string bakingTechniqueType;
        private double weight;

        public Dough(string flourType, string bakingTechniqueType, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechniqueType = bakingTechniqueType;
            this.Weight = weight;
        }
        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                if (!DoughValidator.isValidFlourType(value))
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechniqueType
        {
            get
            {
                return this.bakingTechniqueType;
            }
            set
            {
                if (!DoughValidator.isValidBakingTechnique(value))
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.bakingTechniqueType = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double DoughTotalCalories()
        {
            return this.Weight * 2
                * DoughValidator.GetFlourModifier(this.FlourType)
                * DoughValidator.GetBakingTechniqueModifier(this.BakingTechniqueType);
        }
    }
}

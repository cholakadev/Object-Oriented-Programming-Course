namespace SingleInheritance
{
    using System;
    public class Monster : Character
    {
        interface IMonster
        {
            int Damage { get; set; }
        }
        public Monster(string name, int health, int damage) 
            : base(name, health)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Health: {this.Health}{Environment.NewLine}" +
                $"Damage: {this.Damage}{Environment.NewLine}";
        }
    }
}

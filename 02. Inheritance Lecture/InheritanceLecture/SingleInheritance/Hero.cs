namespace SingleInheritance
{
    using System;
    public class Hero : Character
    {
        interface IHero
        {
            int Damage { get; set; }
            int DamageAbsorb { get; set; }
        }
        public Hero(string name, int health, int damage, int damageAbsorb)
            : base(name, health)
        {
            this.Damage = damage;
            this.DamageAbsorb = damageAbsorb;
        }

        public int Damage { get; set; }
        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Health: {this.Health}{Environment.NewLine}" +
                $"Damage: {this.Damage}{Environment.NewLine}" +
                $"Damage Absorb: {this.DamageAbsorb}{Environment.NewLine}";
        }
    }
}

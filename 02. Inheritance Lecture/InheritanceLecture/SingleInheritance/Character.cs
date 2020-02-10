namespace SingleInheritance
{
    public class Character
    {
        interface IAnimal
        {
            string Name { get; set; }
            int Health { get; set; }
        }
        public Character()
        {
            
        }
        public Character(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }
        public string Name { get; set; }
        public int Health { get; set; }
    }
}

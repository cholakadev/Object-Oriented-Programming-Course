namespace SortPersonByName
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            decimal halfPercentage = percentage / 2;

            if (this.Age < 30)
            {
                this.Salary += this.Salary * halfPercentage / 100;
            }

            else
            {
                this.Salary += this.Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {this.Salary:f2} leva.";
        }
    }
}

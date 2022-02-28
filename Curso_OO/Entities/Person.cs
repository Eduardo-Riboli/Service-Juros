namespace Curso_OO.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Person()
        {

        }

        public Person(string name, double anualincome)
        {
            Name = name; AnualIncome = anualincome;
        }

        public abstract double Tax();

    }
}

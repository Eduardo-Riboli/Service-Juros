namespace Curso_OO.Entities
{
    internal class JuridicPerson : Person
    {

        public int NumberOfEmployees { get; set; }
    
        public JuridicPerson()
        {

        }

        public JuridicPerson(string name, double anualincome, int numberofemployees) : base (name, anualincome)
        {
            NumberOfEmployees = numberofemployees;
        }

        public override double Tax()
        {

            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 14 / 100;
            }
            else
            {
                return AnualIncome * 16 / 100;
            }
        }
    }
}

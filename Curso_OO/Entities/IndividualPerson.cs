namespace Curso_OO.Entities
{
    internal class IndividualPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public IndividualPerson()
        {

        }

        public IndividualPerson(string name, double anualincome, double healthexpenditures) : base (name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                if (HealthExpenditures != 0)
                {
                    return (AnualIncome * 15/100) - (HealthExpenditures * 50/100);
                } 
                return AnualIncome * 15 / 100;
            }
            else
            {
                if (HealthExpenditures != 0)
                {
                    return (AnualIncome * 25 / 100) - (HealthExpenditures * 50 / 100);
                }
                return  AnualIncome * 25 / 100;
            }
        }
    }
}

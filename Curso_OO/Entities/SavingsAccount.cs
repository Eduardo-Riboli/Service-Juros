namespace Curso_OO.Entities
{
    sealed class SavingsAccount : Account //sealed impede que essa classe seja herdada;
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestrate)
            : base (number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //Impede que esse método seja herdado novamente;
        {
            Balance -= amount;
        }

        /*
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);                -> Exemplo de base: utiliza-se o withdraw da classe Account mais qualquer outra conta que desejar.
            Balance -= 2.0;
        }
        */
    }

    
}

namespace Curso_OO.Entities
{
    class BusinessAccount : Account //Quer dizer q a classe BusinessAccount vai ter tudo que a Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() 
        { 
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) // aproveitando os elementos da classe Account;
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
            Balance += amount;
            }
        }
        
    }
    
    

}

namespace Curso_OO.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // private: nenhuma outra classe pode modificar
        public double Balance { get; protected set; } // protected: sub classes podem modificar.

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

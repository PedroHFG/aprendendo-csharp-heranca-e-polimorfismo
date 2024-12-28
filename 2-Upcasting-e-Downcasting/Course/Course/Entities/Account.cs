namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // O modificador private no set indica que o atributo so pode ser modificado na propria classe
        public double Balance { get; protected set; } // O modificador protected no set indica que o atributo pode ser modificado apenas na subclasse que herdar Account e não em outras classes

        public Account() 
        { 
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

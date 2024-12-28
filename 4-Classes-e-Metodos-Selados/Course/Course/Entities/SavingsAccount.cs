using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course.Entities
{
    // Esta classe não pode ser herdada, por causa da palavra sealed
    internal sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) 
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() 
        {
            Balance +=  Balance * InterestRate;
        }

        // Esse metodo não pode ser sobreescrito novamente em outra classe que herde essa classe
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}

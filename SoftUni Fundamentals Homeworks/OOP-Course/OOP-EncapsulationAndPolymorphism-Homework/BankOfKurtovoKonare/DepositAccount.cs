using System;

namespace BankOfKurtovoKonare
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                interest = 0m;
            }
            else
            {
                interest = this.Balance * (1 + this.InterestRate * months);
                return interest;
            }
            return interest;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}

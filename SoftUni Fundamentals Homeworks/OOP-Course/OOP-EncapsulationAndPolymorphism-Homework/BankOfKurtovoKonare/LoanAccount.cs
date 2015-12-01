using System;

namespace BankOfKurtovoKonare
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;
            if (this.Customer == Customer.individual)
            {
                interest = this.Balance * (1 + this.InterestRate * (months - 3));
            }
            else
            {
                interest = this.Balance * (1 + this.InterestRate * (months - 2));
            }
            return interest;
        }
    }
}
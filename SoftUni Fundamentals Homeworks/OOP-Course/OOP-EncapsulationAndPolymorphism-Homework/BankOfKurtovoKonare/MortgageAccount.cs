using System;

namespace BankOfKurtovoKonare
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;
            if (this.Customer == Customer.individual)
            {
                interest = this.Balance * (1 + this.InterestRate * (months - 6));
            }
            else
            {
                decimal halfInterest = this.Balance * (1 + this.InterestRate * 12);
                halfInterest /= 2;
                interest = this.Balance * (1 + this.InterestRate * (months - 12));
                interest += halfInterest;
            }
            return interest;
        }
    }
}
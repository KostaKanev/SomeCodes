namespace BankOfKurtovoKonare
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public decimal CalculateInterest(int months)
        {
            decimal interest = 0m;
            if (this.GetType() == typeof(DepositAccount) &&
                (this.Balance > 0 && this.Balance < 1000))
            {
                return 0m;
            }
            else if (this.GetType() == typeof(LoanAccount))
            {
                if (this.Customer == Customer.individual)
                {
                    interest = this.Balance * (1 + this.InterestRate * (months - 3));
                }
                else if (this.Customer == Customer.company)
                {
                    interest = this.Balance * (1 + this.InterestRate * (months - 2));
                }
            }
            else
            {
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
            }
            return interest;
        }
    }
}
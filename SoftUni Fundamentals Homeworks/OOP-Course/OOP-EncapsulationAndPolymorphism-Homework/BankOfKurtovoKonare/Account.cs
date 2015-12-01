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
        
        public abstract decimal CalculateInterest(int months);
    }
}
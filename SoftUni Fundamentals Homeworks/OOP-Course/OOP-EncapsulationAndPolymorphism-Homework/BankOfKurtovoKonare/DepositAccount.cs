namespace BankOfKurtovoKonare
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}

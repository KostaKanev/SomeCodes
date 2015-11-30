public class Customer : Person
{
    private decimal moneySpent;
    
    public Customer(int id, string firstName, string lastName)
        : base(id, firstName, lastName)
    {
        this.MoneySpent = 0;
    }

    public decimal MoneySpent { get; set; }
}
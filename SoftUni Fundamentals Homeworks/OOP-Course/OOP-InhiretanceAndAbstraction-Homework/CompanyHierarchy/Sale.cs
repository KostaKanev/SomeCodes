using System;

public class Sale
{
    private string productName;
    private DateTime date;
    private decimal price;
    
    public Sale(string productName, DateTime date, decimal price)
    {
        this.ProductName = productName;
        this.Date = date;
        this.Price = price;
    }

    public string ProductName { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
}
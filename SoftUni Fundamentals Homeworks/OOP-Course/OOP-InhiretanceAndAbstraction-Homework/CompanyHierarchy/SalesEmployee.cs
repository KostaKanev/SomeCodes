using System.Collections.Generic;
using System.Text;

public class SalesEmployee : Employee
{
    private List<Sale> sales;

    public SalesEmployee(int id, string firstName, string lastName, DepartmentOptions department)
        : base(id,firstName,lastName, department)
    {
        this.Sales = new List<Sale>();
        this.Salary = this.Sales.Count * 200;
    }

    public List<Sale> Sales { get; set; }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Sales Employee Information...\n");
        builder.Append(string.Format("Name: {0} {1}\n", this.FirstName, this.LastName));
        foreach (var sale in this.Sales)
        {
            builder.Append(string.Format("{5}Sold {0} for {1:F2} lv. in {2}/{3}/{4}\n",
                sale.ProductName,
                sale.Price, 
                sale.Date.Day,
                sale.Date.Month,
                sale.Date.Year, 
                new string(' ',5)));
        }
        return builder.ToString();
    }
}
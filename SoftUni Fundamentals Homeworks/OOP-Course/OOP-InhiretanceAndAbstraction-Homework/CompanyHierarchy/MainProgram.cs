using System;
public class MainProgram
{
    public static void Main()
    {
        var employee = new SalesEmployee(123, "Gosho", "Goshev", Employee.DepartmentOptions.Marketing);
        employee.Sales.Add(new Sale("Fafla", Convert.ToDateTime("11-29-2015"), 0.55m));
        employee.Sales.Add(new Sale("Dyvka", Convert.ToDateTime("11-28-2015"), 0.20m));
        Console.WriteLine(employee.ToString());
        //Console.WriteLine(employee.Department);
        //Console.WriteLine("{0} {1} {2}", employee.Sales[0].ProductName, employee.Sales[0].Date, employee.Sales[0].Price);
        
    }
}
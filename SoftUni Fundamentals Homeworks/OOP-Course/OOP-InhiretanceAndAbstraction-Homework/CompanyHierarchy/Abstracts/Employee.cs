public abstract class Employee : Person
{
    private decimal salary;
    private DepartmentOptions department;
    
    public Employee(int id, string firstName, string lastName, DepartmentOptions department)
        : base(id,firstName,lastName)
    {
        this.Department = department;
    }

    public decimal Salary { get; set; }
    
    public DepartmentOptions Department { get; set; }

    public enum DepartmentOptions
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }
}

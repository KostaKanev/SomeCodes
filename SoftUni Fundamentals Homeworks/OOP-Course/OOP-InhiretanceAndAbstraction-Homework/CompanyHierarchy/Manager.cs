using System.Collections.Generic;

public class Manager : Employee
{
    private List<Employee> employees;

    public Manager(int id, string firstName, string lastName, DepartmentOptions department)
        : base(id,firstName,lastName, department)
    {
        this.Employees = new List<Employee>();
    }

    public List<Employee> Employees { get; set; }
}
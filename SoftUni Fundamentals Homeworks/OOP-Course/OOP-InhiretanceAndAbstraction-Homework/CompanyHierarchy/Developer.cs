using System.Collections.Generic;

public class Developer : Employee
{
    private List<Project> projects;
    
    public Developer(int id, string firstName, string lastName, DepartmentOptions department) :
        base(id, firstName, lastName, department)
    {
        this.Projects = new List<Project>();
    }

    public List<Project> Projects { get; set; }

}
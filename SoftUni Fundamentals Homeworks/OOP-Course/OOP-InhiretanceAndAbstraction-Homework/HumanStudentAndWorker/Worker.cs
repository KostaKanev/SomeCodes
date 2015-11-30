using System;

public class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(decimal weekSalary, int workHoursPerDay) 
        : this(null,null, weekSalary, workHoursPerDay)
    {
    }

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set { this.weekSalary = value; }
    }

    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set { this.workHoursPerDay= value; }
    }

    public decimal MoneyPerHour()
    {
        decimal moneyPerDay = this.weekSalary / 7;
        decimal moneyPerHour = moneyPerDay / this.workHoursPerDay;
        return moneyPerHour;
    }
}
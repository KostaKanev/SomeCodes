using System;

public class Component
{
    private string name;
    private string details;
    private double price;

    public Component() : this("Default", "Default", 0.00d)
    {
    }

    public Component(string name, string details, double price)
    {
        this.name = name;
        this.details = details;
        this.price = price;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Details
    {
        get { return this.details; }
        set { this.details = value; }
    }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
}

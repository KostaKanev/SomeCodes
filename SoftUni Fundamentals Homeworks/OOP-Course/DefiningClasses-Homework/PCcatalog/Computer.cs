using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Computer
{
    private string name;
    private double price;
    private Component processor;
    private Component memory;
    private Component graphicCard;
    private double totalPrice;
    
    public Computer() : this("Default", 0.00d)
    {
    }

    public Computer(string name, double price)
    {
        this.name = name;
        this.price = price;
        this.processor = new Component("Processor","Default",0.00d);
        this.memory = new Component("RAM", "Default", 0.00d);
        this.graphicCard = new Component("Graphic Card", "Default", 0.00d);
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; } 
    }
    
    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public double TotalPrice
    {
        get { return this.totalPrice; }
        set { this.totalPrice = value;}
    }
    
    public Component Processor
    {
        get { return this.processor; }
        set { this.processor = value; }
    }

    public Component Memory
    {
        get { return this.memory; }
        set { this.memory = value; }
    }

    public Component GraphicCard
    {
        get { return this.graphicCard; }
        set { this.graphicCard = value; }
    }

    public override string ToString()
    {
        string name = this.name;
        double total = this.price;
        
        List<Component> components = new List<Component>();

        components.Add(this.processor);
        components.Add(this.memory);
        components.Add(this.graphicCard);

        StringBuilder builder = new StringBuilder();
        builder.Append(string.Format("Computer name: {0}\n", name));
        builder.Append(string.Format("Computer price: {0} lv.\n\n", price));
        builder.Append("Components\n------------\n");
        foreach (var item in components)
        {
            builder.Append(string.Format("{0} --> ", item.Name).PadLeft(25, ' '));
            builder.Append(string.Format("{0} --> ", item.Details).PadLeft(25, ' '));
            builder.Append(string.Format("Price: {0:F2} lv.\n", item.Price).PadLeft(25, ' '));
            total += item.Price;
        }
        this.totalPrice = total;

        builder.Append(string.Format("\nTotal price: {0:F2} lv.\n", this.totalPrice));
        builder.Append(new string('=', 100));

        return builder.ToString();
    }
}
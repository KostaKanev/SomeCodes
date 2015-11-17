using System;

public class Laptop
{
    //model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.

    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicCard;
    private string hdd;
    private int price;

    private Battery battery;

    public Laptop() : this("default", "default", "default", 0, "default", "default", 0, "default", "default")
    {
    }

    public Laptop(string model,string manufacturer, string processor,
        int ram, string graphicCard, string hdd, int price, string batteryType, string batteryLife)
    {
        if (model == "" || manufacturer == "" || 
            processor == "" || graphicCard == "" || hdd == "")
        {
            throw new ArgumentException("Some empty laptop value except battery");
        }
        else if (ram < 0 || price < 0)
        {
            throw new ArgumentException("HDD space or price can't be negative");
        }
        else
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.ram = ram;
            this.graphicCard = graphicCard;
            this.hdd = hdd;
            this.price = price;

            this.battery = new Battery();
            this.battery.BatteryType = batteryType;
            this.battery.BatteryLife = batteryLife;
        }
    }

    public string Model
    {
        get { return this.manufacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.model = value;
            }
        }
    }

    public string Manufacturer
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.processor = value;
            }
        }
    }

    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.ram = value;
            }
        }
    }

    public string GraphicCard
    {
        get { return this.graphicCard; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.graphicCard = value;
            }
        }
    }
    
    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
            else
            {
                this.hdd = value;
            }
        }
    }

    public int Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Can't set negative value");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public string BatteryType
    {
        get { return this.battery.BatteryType; }
        set { this.battery.BatteryType = value; }
    }

    public override string ToString()
    {
        string model = string.Format("Model: {0}", this.model);
        string manufacturer = string.Format("Manufacturer: {0}", this.manufacturer);
        string processor = string.Format("Processor: {0}", this.processor);
        int ram = this.ram;
        string graphicCard = string.Format("Graphic Card: {0}", this.graphicCard);
        string hdd = string.Format("HDD: {0}", this.hdd);
        int price = this.price;
        string batteryType = string.Format("Battery Type: {0}", this.battery.BatteryType);
        string batteryLife = string.Format("Battery Life: {0}", this.battery.BatteryLife);

        string information = string.Format("{0}\n{1}\n{2}\nRam: {3}\n{4}\n{5}\n{6}\nPrice: {7}\n{8}\n{9}\n",
            model, manufacturer, processor, ram, graphicCard,
            hdd, processor, price, batteryType, batteryLife);
        
        return information;
    }
}
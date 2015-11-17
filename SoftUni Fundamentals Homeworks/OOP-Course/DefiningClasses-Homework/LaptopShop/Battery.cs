using System;

public class Battery
{
    private string batteryType;
    private string batteryLife;

    public Battery() : this("default", "default")
    {
    }

    public Battery(string type, string life)
    {
        if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(life))
        {
            throw new ArgumentException("Some empty battery value");
        }
        else
        {
            this.batteryType = type;
            this.batteryLife = life;
        }
    }

    public string BatteryType
    {
        get { return this.batteryType; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
        }
    }
    public string BatteryLife
    {
        get { return this.batteryLife; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't set null or empty value");
            }
        }
    }
}
using System;

public class MainProgram
{
    public static void Main()
    {
        Laptop laptop = new Laptop();

        laptop.Model = "Lenovo Yoga 2 Pro";
        laptop.Manufacturer = "Lenovo";
        laptop.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
        laptop.Ram = 8;
        laptop.GraphicCard = "Intel HD Graphics 4400";
        laptop.Hdd = "128GB SSD";
        laptop.BatteryType = "Li-Ion, 4-cells, 2550 mAh";
        laptop.BatteryLife = "4.5 hours";
        laptop.Price = 2259.00d;

        Console.WriteLine(laptop.ToString());

        Laptop anotherLaptop = new Laptop("Dell Inspiron 5758", "Dell", "Intel Core i5-5200U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8,
            "NVIDIA GeForce 920M", "1 TB HDD", 1100d, "Li-Ion, 4-cells, 40Wh", "4.5 hours");

        Console.WriteLine(anotherLaptop.ToString());
        
    }
}
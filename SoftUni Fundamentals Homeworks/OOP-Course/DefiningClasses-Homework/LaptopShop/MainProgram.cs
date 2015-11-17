using System;

public class MainProgram
{
    public static void Main()
    {
        Laptop laptop = new Laptop();

        laptop.BatteryType = "asdf";
        Console.WriteLine(laptop.BatteryType);

    }
}
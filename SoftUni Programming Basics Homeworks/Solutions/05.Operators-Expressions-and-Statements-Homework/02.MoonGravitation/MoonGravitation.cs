using System;
public class MoonGravitation
{
    public static void Main()
    {
        Console.Write("Enter weight of a man on the Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Weight of a man on the Moon is {0}", weightOnMoon);
    }
}
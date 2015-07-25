using System;
public class TheBiggestOfThreeNumbers
{
    public static void Main()
    {
        Console.Write("Enter number A: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter number C: ");
        double numberC = double.Parse(Console.ReadLine());

        if (numberA > numberB && numberA > numberC)
        {
            Console.WriteLine(numberA);
        }
        else if (numberB > numberA && numberB > numberC)
        {
            Console.WriteLine(numberB);
        }
        else if (numberC > numberA && numberC > numberB)
        {
            Console.WriteLine(numberC);
        }
        else
        {
            Console.WriteLine("Equal biggest numbers!");
        }
    }
}
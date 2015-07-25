using System;
public class MultiplicationSign
{
    public static void Main()
    {
        Console.Write("Enter number A: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter number C: ");
        double numberC = double.Parse(Console.ReadLine());

        if (numberA == 0 || numberB == 0 || numberC == 0)
        {
            Console.WriteLine("The product = 0");
            return;
        }
        else if ((numberA < 0 && numberB < 0 && numberC < 0) ||
                (numberA < 0 && numberB > 0 && numberC > 0) ||
                (numberA > 0 && numberB > 0 && numberC < 0))
        {
            Console.WriteLine("The sign of product is: -");
            return;
        }
        Console.WriteLine("The sign of product is: +");
    }
}
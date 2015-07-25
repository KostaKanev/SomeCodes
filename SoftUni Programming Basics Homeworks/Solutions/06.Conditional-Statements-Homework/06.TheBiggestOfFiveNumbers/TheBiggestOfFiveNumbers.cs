using System;
public class TheBiggestOfFiveNumbers
{
    public static void Main()
    {
        //Read five number from the console
        Console.Write("Enter number A: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter number C: ");
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("Enter number D: ");
        double numberD = double.Parse(Console.ReadLine());
        Console.Write("Enter number E: ");
        double numberE = double.Parse(Console.ReadLine());

        //Using five if statements to find biggest of five numbers
        if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
        {
            Console.WriteLine("The biggest number is: " + numberA);
        }
        else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
        {
            Console.WriteLine("The biggest number is: " + numberB);
        }
        else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
        {
            Console.WriteLine("The biggest number is: " + numberC);
        }
        else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
        {
            Console.WriteLine("The biggest number is: " + numberD);
        }
        else if (numberE > numberA && numberE > numberB && numberE > numberC && numberE > numberD)
        {
            Console.WriteLine("The biggest number is: " + numberE);
        }
    }
}
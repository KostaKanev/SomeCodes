using System;
public class Sort3Numbers
{
    public static void Main()
    {
        //Read 3 numbers from the console
        Console.Write("Enter number A: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter number C: ");
        double numberC = double.Parse(Console.ReadLine());

        //Sort with nested if statements
        if (numberA > numberB && numberA > numberC)
        {
            Console.Write(numberA);
            if (numberB > numberC)
            {
                Console.WriteLine(" {0} {1}", numberB, numberC);
            }
            else
            {
                Console.WriteLine(" {0} {1}", numberC, numberB);
            }
        }
        else if (numberB > numberA && numberB > numberC)
        {
            Console.Write(numberB);
            if (numberA > numberC)
            {
                Console.WriteLine(" {0} {1}", numberA, numberC);
            }
            else
            {
                Console.WriteLine(" {0} {1}", numberC, numberA);
            }
        }
        else if (numberC > numberA && numberC > numberB)
        {
            Console.Write(numberC);
            if (numberA > numberB)
            {
                Console.WriteLine(" {0} {1}", numberA, numberB);
            }
            else
            {
                Console.WriteLine(" {0} {1}", numberB, numberA);
            }
        }
    }
}
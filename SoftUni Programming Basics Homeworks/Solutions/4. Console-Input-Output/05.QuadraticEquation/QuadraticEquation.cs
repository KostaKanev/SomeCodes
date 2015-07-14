using System;
public class QuadraticEquation
{
    public static void Main()
    {
        //Read coefficients from the console and parse to double
        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());

        //Calculate discriminant and roots
        double discriminant = Math.Pow(coefB, 2) - (4 * coefA * coefC);
        double firstRoot = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
        double secRoot = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);

        //Check discriminant to print results
        if (discriminant == 0)
        {
            Console.WriteLine("x1=x2={0}", firstRoot);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1={0}; x2={1}", firstRoot, secRoot);
        }
    }
}
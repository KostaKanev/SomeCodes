using System;
public class Trapezoids
{
    public static void Main()
    {
        //Read the sides and height of the trapezoid from the console
        double sideOne = double.Parse(Console.ReadLine());
        double sideTwo = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        //Calculate the expression by formula and print the result
        Console.WriteLine("The Area of the trapezoid = {0}", ((sideOne + sideTwo) / 2) * height);
    }
}
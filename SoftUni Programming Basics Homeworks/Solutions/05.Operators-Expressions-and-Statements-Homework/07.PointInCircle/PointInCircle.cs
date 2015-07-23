using System;

public class PointInCircle
{
    public static void Main()
    {
        //Read point coordinates from the console
        Console.Write("Enter X coordinate of point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate of point: ");
        double y = double.Parse(Console.ReadLine());

        //Make circle
        double cirlceX = 0;
        double cirlceY = 0;
        double radius = 2;

        //Check whether the point is in the circle and print the result
        bool isInside = true ? Math.Pow(x - cirlceX, 2) + Math.Pow(y - cirlceY, 2) <= Math.Pow(radius, 2) : false;
        Console.WriteLine("Is point in the circle ? " + isInside);
    }
}
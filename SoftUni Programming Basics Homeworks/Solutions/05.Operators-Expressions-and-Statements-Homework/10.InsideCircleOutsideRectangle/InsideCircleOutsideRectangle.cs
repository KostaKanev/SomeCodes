using System;
public class InsideCircleOutsideRectangle
{
    public static void Main()
    {
        //Read point coordinates from the console
        Console.Write("Enter X coordinate of point: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate of point: ");
        double yCoord = double.Parse(Console.ReadLine());

        //Make circle
        double cirlceX = 1;
        double cirlceY = 1;
        double radius = 1.5;

        //Check whether the point is inside the circle and outside the rectangle
        bool isInside = true ? Math.Pow(xCoord - cirlceX, 2) + Math.Pow(yCoord - cirlceY, 2) <= Math.Pow(radius, 2) : false;
        Console.Write("Is the point inside the circle and outside the rectangle? ");
        if (isInside && yCoord > 1)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

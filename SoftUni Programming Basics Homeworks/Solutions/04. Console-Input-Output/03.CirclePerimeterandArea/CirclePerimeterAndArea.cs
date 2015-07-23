using System;
public class CirclePerimeterAndArea
{
    public static void Main()
    {
        //Parse input to double variable
        double radius = double.Parse(Console.ReadLine());
        
        //Calculate perimeter and area by formulas
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        

        //Print the results
        Console.WriteLine("Perimeter = {0:F2}" , perimeter);
        Console.WriteLine("Area = {0:F2}" , area);
    }
}
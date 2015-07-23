using System;
public class Rectangles
{
    public static void Main()
    {
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        double perimeter = (width * 2) + (height * 2);
        double area = width * height;
        Console.WriteLine("Perimeter = {0}\nArea = {1}",perimeter,area);
    }
}

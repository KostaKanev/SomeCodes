using System;
using Shapes;

public class MainProgram
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(4, 6);
        Rhombus rhombus = new Rhombus(2, 5);
        Circle circle = new Circle(12);

        Console.WriteLine("Rectangle:\n\tArea: {0:F3}\n\tPerimeter: {1:F3}\n",
            rectangle.CalculateArea(),
            rectangle.CalculatePerimeter()
            );
        Console.WriteLine("Rhombus:\n\tArea: {0:F3}\n\tPerimeter: {1:F3}\n",
            rhombus.CalculateArea(),
            rhombus.CalculatePerimeter()
            );
        Console.WriteLine("Circle:\n\tArea: {0:F3}\n\tPerimeter: {1:F3}\n",
            circle.CalculateArea(),
            circle.CalculatePerimeter()
            );
    }
}
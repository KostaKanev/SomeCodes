using System;
public class ComparingFloats
{
    public static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001d;

        bool check = Math.Abs(firstNumber - secondNumber) < eps;

        if (Math.Abs(firstNumber - secondNumber) < eps)
        {
            Console.WriteLine(check);
        }
        else
        {
            Console.WriteLine(check);
        }
    }
}
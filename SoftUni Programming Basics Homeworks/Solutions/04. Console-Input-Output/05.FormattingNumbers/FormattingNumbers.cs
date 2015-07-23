using System;
public class FormattingNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
       
        Console.Write("|{0,-10:X}", firstNumber);
        Console.Write("|{0,10}|",Convert.ToString(firstNumber,2).PadLeft(10 , '0'));
        Console.Write("{0,10:F2}|", secondNumber);
        Console.WriteLine("{0,-10:F3}|", thirdNumber);
    }
}
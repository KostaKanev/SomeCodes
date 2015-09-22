using System;
using System.Text;

public class ReverseNumber
{
    public static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
    }

    public static double GetReversedNumber(double number)
    {
        string result = number.ToString();
        StringBuilder reversedNumber = new StringBuilder();
        reversedNumber.Length = result.Length;
        for (int i = 0; i < result.Length; i++)
        {
            reversedNumber.Insert(i, result[result.Length - i - 1]);
        }
        double num = Convert.ToDouble(reversedNumber.ToString());
        return num;
    }
} 
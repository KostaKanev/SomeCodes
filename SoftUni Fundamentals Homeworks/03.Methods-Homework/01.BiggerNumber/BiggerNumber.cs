using System;

public class BiggerNumber
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber= int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstNumber,secondNumber));
    }

    public static int GetMax(int firstNum, int secNum)
    {
        int bigger = firstNum;
        if (secNum > firstNum)
        {
            bigger = secNum;
        }
        return bigger;
    }
}
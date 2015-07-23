using System;
public class ThirdDigitIs7
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        if (int.Parse(number) > 100)
        {
            bool isSeven = true ? number[number.Length - 3] == '7' : false;
            Console.WriteLine("Is Third digit 7 ? " + isSeven);
        }
        else
        {
            Console.WriteLine("Is Third digit 7 ? " + false);
        }
    }
}

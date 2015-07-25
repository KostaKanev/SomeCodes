using System;
public class DigitAsWord
{
    public static void Main()
    {
        Console.Write("Please enter a digit: ");
        string digitStr = Console.ReadLine();
        string allowedDigits = "0 1 2 3 4 5 6 7 8 9";
        string digitAsWord = null;
        
        if (allowedDigits.Contains(digitStr))
        {
            if (int.Parse(digitStr) >= 0 && int.Parse(digitStr) <= 9)
            {
                int digit = int.Parse(digitStr);

                switch (digit)
                {
                    case 0:
                        digitAsWord = "Zero";
                        break;
                    case 1:
                        digitAsWord = "One";
                        break;
                    case 2:
                        digitAsWord = "Two";
                        break;
                    case 3:
                        digitAsWord = "Three";
                        break;
                    case 4:
                        digitAsWord = "Four";
                        break;
                    case 5:
                        digitAsWord = "Five";
                        break;
                    case 6:
                        digitAsWord = "Six";
                        break;
                    case 7:
                        digitAsWord = "Seven";
                        break;
                    case 8:
                        digitAsWord = "Eight";
                        break;
                    case 9:
                        digitAsWord = "Nine";
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Your digit as word: " + digitAsWord);
            }
        }
        else
        {
            Console.WriteLine("Not a digit!");
        }
    }
}
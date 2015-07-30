using System;
public class NumberAsWords
{
    public static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        
        string[] numbersTo19 = new string[]
        {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven", "Twelve" ,"Thirteen" , "Fourteen" ,
            "Fifteen" , "SixTeen","Seventeen", "Eighteen","Nineteen"
        };

        string[] tenths = new string[]
        {
            "Ten", "Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety"
        };
        
        if (number == 0)
        {
            Console.WriteLine("Zero");
            return;
        }
        else if (number > 999)
        {
            Console.WriteLine("Bigger than 999");
            return;
        }

        if (number % 10 == 0 && number < 100)
        {
            Console.WriteLine(tenths[(number / 10) - 1]);
        }
        else if (number < 20)
        {
            Console.WriteLine(numbersTo19[number - 1]);
        }
        else if (number < 100)
        {
            Console.WriteLine(tenths[(number / 10) - 1] + " " + numbersTo19[(number % 10) - 1]);
        }
        else if (number % 100 == 0)
        {
            Console.WriteLine(numbersTo19[(number / 100) - 1] + " hundred");
        }
        else if (number % 10 == 0)
        {
            Console.WriteLine(numbersTo19[(number / 100) - 1] + " hundred and " + tenths[((number / 10) % 10) - 1]);
        }
        else if ((number / 10) % 10 < 2)
        {
            Console.WriteLine(numbersTo19[(number / 100) - 1] + " hundred and " + numbersTo19[(number % 100) - 1]);
        }
        else
        { 
             Console.WriteLine(numbersTo19[(number / 100) - 1] + " hundred and " + tenths[((number / 10) % 10) - 1] + " " + numbersTo19[(number % 10) - 1]);
        }
    }
}
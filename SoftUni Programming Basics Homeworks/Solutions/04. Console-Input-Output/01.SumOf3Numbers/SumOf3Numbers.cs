using System;
    public class SumOf3Numbers
    {
        public static void Main()
        {
            //Declare double type variable for string readed from console and parse to double
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumbers = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            //Calculate and print the sum of numbers
            double sum = firstNumber + secondNumbers + thirdNumber;
            Console.WriteLine(sum);
        }
    }
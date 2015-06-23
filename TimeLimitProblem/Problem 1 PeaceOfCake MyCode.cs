namespace Problem_1___Peace_of_Cake
{
    using System;
    public class PeaceOfCake
    {
        public static void Main()
        {
            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());
            decimal numberC = decimal.Parse(Console.ReadLine());
            decimal numberD = decimal.Parse(Console.ReadLine());
            
            decimal denominator = numberB * numberD;
            decimal numerator = (numberA * (denominator / numberB)) + (numberC * (denominator / numberD));

            if (numerator > denominator)
            {
                Console.WriteLine("{0:F0}" , numerator/denominator);
            }
            else
            {
                Console.WriteLine("{0:F22}" , numerator/denominator);
            }

            Console.WriteLine("{0}/{1}", numerator , denominator);
        }
    }
}
using System;

public class ReversedString
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length < 20)
        {
            Console.WriteLine("{0}{1}",input,new string('*',20 - input.Length));
        }
        else
        {
            Console.WriteLine(input.Remove(20,input.Length - 20));
        }
    }
}
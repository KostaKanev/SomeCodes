using System;
public class KingofThieves
{
    public static void Main(string[] args)
    {
        int size = 13; // int.Parse(Console.ReadLine());
        string input = "a"; // Console.ReadLine();
        char gem = input[0];
        int helper = size / 2;
        int numOfGems = 1;
 
        for (int i = 1; i <= size / 2; i++)
        {
            
            Console.Write(new string('-', helper));
            Console.Write(new string(gem , numOfGems));
            Console.Write(new string('-', helper));
            Console.WriteLine();
            numOfGems += 2;
            helper--;
        }
        Console.WriteLine(new string(gem , size));
        numOfGems = size - 2;
        for (int i = 1; i <= size / 2; i++)
        {
            Console.Write(new string('-', i));
            Console.Write(new string(gem, numOfGems));
            Console.Write(new string('-', i));
            Console.WriteLine();
            numOfGems -= 2;
        }
    }
}
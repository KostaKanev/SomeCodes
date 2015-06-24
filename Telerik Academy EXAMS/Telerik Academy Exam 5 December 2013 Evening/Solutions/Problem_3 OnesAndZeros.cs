using System;
public class OnesAndZeros
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(input, 2).PadLeft(32, '0');

        string zeroTopBot = "###";
        string zeroBody = "#.#";
        string oneTopBody = ".#.";
        string oneUnique = "##.";
        string oneBot = zeroTopBot;

        for (int row = 0; row < 5; row++)
        {
            for (int bit = 16; bit < binary.Length; bit++)
            {
                if (binary[bit] == '0')
                {
                    if (row == 0 || row == 4)
                    {
                        Console.Write(zeroTopBot);
                    }
                    else
                    {
                        Console.Write(zeroBody);
                    }
                }
                else
                {
                    if (row == 1)
                    {
                        Console.Write(oneUnique);
                    }
                    else if (row == 4)
                    {
                        Console.Write(oneBot);
                    }
                    else
                    {
                        Console.Write(oneTopBody);
                    }
                }
                if (bit != binary.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

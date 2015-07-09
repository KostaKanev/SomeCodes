using System;
public class Nums
{
    public static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        for (int i = startNum; i <= endNum ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(i));
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Pow(i , 2));
            }
        }
    }
}

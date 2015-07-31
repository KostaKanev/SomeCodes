using System;
using System.Collections.Generic;

public class ZeroSubsets
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter set of five numbers");

        var list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            list.Add(int.Parse(Console.ReadLine()));
        }
        if (list[0] == 0 && list[1] == 0 &&
            list[2] == 0 && list[3] == 0 && 
            list[4] == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
            return;
        }

        bool haveZeroSubset = false;
        int subsetsCounter = 0;

        Console.WriteLine("\nZero Subsets List\n" + new string('-',20));
        //Two elements subsets
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] + list[j] == 0)
                {
                    subsetsCounter++;
                    Console.WriteLine("Subset {0}: ({1}) + ({2}) = 0",subsetsCounter , list[i], list[j]);
                    haveZeroSubset = true;
                }
            }
        }
        //Three elements subsets
        for (int i = 0; i < list.Count - 2; i++)
        {
            for (int j = i + 1; j < list.Count - 1; j++)
            {
                for (int k = j + 1; k < list.Count; k++)
                {
                    if (list[i] + list[j] + list[k] == 0)
                    {
                        subsetsCounter++;
                        Console.WriteLine("Subset {0}: ({1}) + ({2}) + ({3}) = 0",subsetsCounter , list[i], list[j], list[k]);
                        haveZeroSubset = true;
                    }
                }
            }
        }
        //Four elements subsets
        for (int i = 0; i < list.Count - 3; i++)
        {
            for (int j = i + 1; j < list.Count - 2; j++)
            {
                for (int k = j + 1; k < list.Count - 1; k++)
                {
                    for (int l = k + 1; l < list.Count; l++)
                    {
                        if (list[i] + list[j] + list[k] + list[l] == 0)
                        {
                            subsetsCounter++;
                            Console.WriteLine("Subset {0}: ({1}) + ({2}) + ({3}) + ({4}) = 0",subsetsCounter , list[i], list[j], list[k], list[l]);
                            haveZeroSubset = true;
                        }
                    }
                }
            }
        }

        if (!haveZeroSubset)
        {
            Console.WriteLine("No Zero Subsets!");
        }
    }
}
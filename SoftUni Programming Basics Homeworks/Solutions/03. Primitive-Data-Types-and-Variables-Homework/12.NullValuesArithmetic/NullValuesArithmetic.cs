using System;
public class NullValuesArithmetic
{
    public static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine(nullInteger);
        Console.WriteLine(nullDouble);

        Console.WriteLine(nullInteger + null);
        Console.WriteLine(nullDouble + null);

        Console.WriteLine(nullInteger + 10);
        Console.WriteLine(nullDouble + 20);
    }
}
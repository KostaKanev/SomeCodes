using System;
public class ExchangeVariableValues
{
    public static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\na = " + a + "\nb = " + b);

        int help = a;
        a = b;
        b = help;
        Console.WriteLine("After:\na = " + a + "\nb = " + b);
    }
}
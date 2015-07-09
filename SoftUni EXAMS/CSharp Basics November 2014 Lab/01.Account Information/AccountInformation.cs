using System;
public class AccountInformation
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int clientID = int.Parse(Console.ReadLine());
        double totalBalance = double.Parse(Console.ReadLine());

        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: {0}", clientID);
        Console.WriteLine("Total balance: {0:F2}",totalBalance);

        if (totalBalance < 0)
        {
            Console.WriteLine("Active: no");
        }
        else
        {
            Console.WriteLine("Active: yes");
        }
    }
}

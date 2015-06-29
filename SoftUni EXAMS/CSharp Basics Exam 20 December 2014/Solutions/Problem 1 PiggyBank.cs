using System;
public class PiggyBank
{
    public static void Main()
    {
        int prizeOfTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int cashForMonth = ((30 - partyDays) * 2) - (partyDays * 5);
        int spendedMoney = partyDays * 5;

        double allMonths = prizeOfTank / (double)cashForMonth;

        double years = Math.Floor(allMonths / 12d);
        double months = Math.Ceiling(allMonths % 12d);
        if (partyDays < 8)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months" , years , months);
        }
    }
}

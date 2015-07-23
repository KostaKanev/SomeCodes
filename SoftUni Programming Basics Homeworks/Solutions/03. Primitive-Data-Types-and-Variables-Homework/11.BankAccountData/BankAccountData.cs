using System;
public class BankAccountData
{
    public static void Main()
    {
        string firstName = "first name";
        string middleName = "middle name";
        string lastName = "last name";

        int balance = 0;
        string bankName = "Bank name";
        string iBAN = "0000000000";

        string firstCreditCard = "000000000000000";
        string secondCreditCard = "111111111111111";
        string thirdCreditCard = "222222222222222";

        Console.WriteLine("first name: " + firstName);
        Console.WriteLine("middle name: " + middleName);
        Console.WriteLine("last name: " + lastName);
        Console.WriteLine("balance: " + balance);
        Console.WriteLine("bank name: " + bankName);
        Console.WriteLine("IBAN:  " + iBAN);
        Console.WriteLine("first credit card: " + firstCreditCard);
        Console.WriteLine("second credit card: " + secondCreditCard);
        Console.WriteLine("third credit card: " + thirdCreditCard);
    }
}
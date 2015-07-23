using System;
public class PrintCompanyInformation
{
    public static void Main()
    {
        //Declare variables for company information
        string companyName = Console.ReadLine();
        string companyAddres = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string fax = Console.ReadLine();
        string website = Console.ReadLine();

        //Declare variables for menager information
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        //Print back inputs
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddres);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
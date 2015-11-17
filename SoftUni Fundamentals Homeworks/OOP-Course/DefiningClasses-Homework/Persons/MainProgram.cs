using System;

public class MainProgram
{
    public static void Main()
    {
        Person pesho = new Person("Pesho", 25,"pesho@gmail.com");

        pesho.Email = null;
        Console.WriteLine(pesho.ToString());
    }
}
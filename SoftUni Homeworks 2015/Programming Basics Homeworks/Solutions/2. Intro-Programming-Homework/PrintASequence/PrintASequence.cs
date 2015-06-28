using System;
public class PrintASequence
{
    public static void Main()
    {
        //Make loop from 2 to 11
        for (int member = 2; member < 12; member++)
        {
            //If the member is even print positive
            if (member % 2 == 0)
            {
                Console.Write("{0},", member);
            }
            //To escape the last comma I check the last member and print only it.
            //Print with negative sign , because the member is odd.
            //Go to next line.
            else if (member == 11)
            {
                Console.WriteLine("{0}", -member);
            }
            //The second and last case is that member may be odd
            //Print negative sign
            else
            {
                Console.Write("{0},", -member);
            }
        }
    }
}

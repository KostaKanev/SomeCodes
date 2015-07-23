using System;
public class PrintLongSequence
{
    public static void Main()
    {
        //Make loop from 2 to 1001
        for (int member = 2; member < 1002; member++)
        {
            //If the member is even print positive
            if (member % 2 == 0)
            {
                Console.Write("{0},", member);
            }
            //To escape the last comma I check the last member and print only it.
            //Print with negative sign , because the member is odd.
            //Go to next line.
            else if (member == 1001)
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

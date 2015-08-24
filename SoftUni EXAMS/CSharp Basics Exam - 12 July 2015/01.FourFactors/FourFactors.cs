using System;

public class FourFactors
{
    public static void Main()
    {
        double[] inputValues = new double[8];

        for (int i = 0; i < inputValues.Length; i++)
        {
            inputValues[i] = double.Parse(Console.ReadLine());
        }
        
        double efg = (inputValues[0] + 0.5 * inputValues[2]) / inputValues[1];
        double tov = inputValues[3] / (inputValues[1] + 0.44 * inputValues[7] + inputValues[3]);
        double orb = inputValues[4] / (inputValues[4] + inputValues[5]);
        double ft = inputValues[6] / inputValues[1];

        Console.WriteLine("eFG% {0:F3}", efg);
        Console.WriteLine("TOV% {0:F3}", tov);
        Console.WriteLine("ORB% {0:F3}", orb);
        Console.WriteLine("FT% {0:F3}", ft);
    }
}
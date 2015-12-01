using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        //PROBLEM 1
        //Printing point coordinates
        Point3D point = new Point3D(5, 3, 2);
        Point3D point1 = new Point3D(2, 3, 4);

        double distance = DistanceCalculator.CalcDistanceBetweenPoints(point,point1);
        Console.WriteLine("Distance = {0}", distance);

        //PROBLEM 2
        //Make Path with random points
        Path3D path = new Path3D();
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randX = rand.Next(0, 100);
            int randY = rand.Next(0, 100);
            int randZ = rand.Next(0, 100);
            Point3D currentPoint = new Point3D(randX, randY, randZ);
            path.AddPointToPath(currentPoint);
        }
    }
}
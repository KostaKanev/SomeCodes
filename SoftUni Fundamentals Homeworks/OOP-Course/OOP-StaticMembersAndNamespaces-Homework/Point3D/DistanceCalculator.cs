using System;

public static class DistanceCalculator
{
    public static double CalcDistanceBetweenPoints(Point3D firstPoint, Point3D secondPoint)
    {
        double xd = secondPoint.X - firstPoint.X;
        double yd = secondPoint.Y - firstPoint.Y;
        double zd = secondPoint.Z - firstPoint.Z;

        double distance = Math.Sqrt((xd * xd) + (yd * yd) + (zd * zd));
        return distance;
    }
}
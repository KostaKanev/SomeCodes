using System;

public class Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly string startingPoint;

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
        this.StartingPoint = string.Format("Starting point\nX: 0, Y: 0, Z: 0\n");

    }
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public string StartingPoint { get; private set; }

    public override string ToString()
    {
        string information = string.Format("Point X: {0}\nPoint Y: {1}\nPoint Z: {2}", this.X, this.Y, this.Z);
        return information;
    }
}
using System;
using System.Collections.Generic;

public class Path3D
{
    private List<Point3D> path;
    
    public Path3D()
    {
        this.Path = new List<Point3D>();
    }
    
    public List<Point3D> Path { get; private set; }

    public void AddPointToPath(Point3D point)
    {
        this.Path.Add(point);
    }
}
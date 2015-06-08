using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;


class Path3D
{
    private List<Point3D> path = new List<Point3D>();

    public List<Point3D> Path
    {
        get { return this.path;}
    }

    public Path3D(params Point3D[] pointsList)
    {
        this.GetPoints(pointsList);
    }

    public void GetPoints(params Point3D[] pointsList)
    {
        foreach (var point3D in pointsList)
        {
            this.Path.Add(point3D);
        }
    }

    public override string ToString()
    {
        StringBuilder pointsPath = new StringBuilder("Path:\n");
        for (int i = 0; i < this.Path.Count; i++)
        {
            pointsPath.AppendFormat("point{0}: x={1} y={2} z={3}\n", i + 1, this.Path[i].X, this.Path[i].Y, this.Path[i].Z);
        }

        return pointsPath.ToString();
    }
}


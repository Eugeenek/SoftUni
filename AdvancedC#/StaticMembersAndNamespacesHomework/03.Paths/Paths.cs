using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;


class Paths 
{
    static void Main()
    {
        Point3D [] pointsDs = new Point3D[2];
        Point3D point1 = new Point3D(0, 5, 6);
        Point3D point2 = new Point3D(0, 3.5, 2.5);
        pointsDs[0] = point1;
        pointsDs[1] = point2;
        Path3D path=new Path3D(pointsDs);

        Storage.SaveToFIle("../../pathOfPoints.txt",path.ToString());
        Console.WriteLine(Storage.LoadFromFile("../../pathOfPoints.txt"));


    }
}

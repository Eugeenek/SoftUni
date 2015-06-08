using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;



class DistanceCalculator
{
    static void Main(string[] args)
    {
        Point3D firstPoint3D = new Point3D(5.2, 3.5, 4);
        Point3D secPoint3D = new Point3D(5,-2.5,6);

        Console.WriteLine(firstPoint3D);
        Console.WriteLine(secPoint3D);
        Console.WriteLine();
        double calculatedDistance = DistanceCalc.CalculateDistance(firstPoint3D,secPoint3D);
        Console.WriteLine("The distance between the two point you have entered is: {0}",calculatedDistance);
    }
}


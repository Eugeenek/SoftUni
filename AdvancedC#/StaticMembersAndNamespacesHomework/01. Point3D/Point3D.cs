using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startinPoint3D = new Point3D(0,0,0);
        private double x;
        private double y;
        private double z;

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartinPoint3D
        {
            get { return startinPoint3D; }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("The coordinates of the point you have entered are: \n X = {0}\n Y = {1} \n Z = {2} ",this.X,this.Y,this.Z);
        }
    }
}

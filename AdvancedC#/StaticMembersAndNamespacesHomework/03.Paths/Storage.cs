using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _01.Point3D;

static class Storage
{
    public static void SaveToFIle(string filePath, string pointsPath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(pointsPath);
        }
    }

    public static Path3D LoadFromFile(string file)
    {

        Path3D path = new Path3D();

        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            const string PointPattern = @"[xyz=:\-\s](\d+(?:(?:\.|,)\d+)*)";

            while (line != null)
            {
                MatchCollection matches = Regex.Matches(line, PointPattern);
                if (matches.Count == 3)
                {
                    double x = double.Parse(matches[0].Groups[1].Value);
                    double y = double.Parse(matches[1].Groups[1].Value);
                    double z = double.Parse(matches[2].Groups[1].Value);

                    Point3D point = new Point3D(x, y, z);
                    path.GetPoints(point);
                }

                line = reader.ReadLine();
            }
        }
        return path;
    }
}


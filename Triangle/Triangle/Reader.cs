using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Triangle
{
    class Reader
    {
        public static Triangle[] Read(string file)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double x3 = 0;
            double y3 = 0;
            Char delimiter = ' ';// разделение

            string[] Lines = File.ReadAllLines(file);//массив строк, который содержит значение элемента
            Triangle[] trianglemass = new Triangle[Lines.Length];

            for (int i = 0; i < Lines.Length; i++)
            {
                string value = Lines[i];
                string[] substrings = value.Split(delimiter);

                x1 = Convert.ToDouble(substrings[0]);
                y1 = Convert.ToDouble(substrings[1]);
                x2 = Convert.ToDouble(substrings[2]);
                y2 = Convert.ToDouble(substrings[3]);
                x3 = Convert.ToDouble(substrings[4]);
                y3 = Convert.ToDouble(substrings[5]);


                Point Point1 = new Point(x1, y1);
                Point Point2 = new Point(x2, y2);
                Point Point3 = new Point(x3, y3);

                Triangle temp = new Triangle(Point1, Point2, Point3);
                trianglemass[i] = temp;
            }
            return trianglemass;
        }
    }
}


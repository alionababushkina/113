using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Average
    {
        double TotalPerimeter = 0;
        double TotalArea = 0;
        double AveragePerimeter = 0;
        double AverageArea = 0;
        double count1 = 0;
        double count2 = 0;
        public void Average1()
        {
            Triangle[] triangles = Reader.Read("Point.txt");
            for (int i = 0; i < triangles.Length; i++)


            {
                if (triangles[i].Right())
                {

                    TotalPerimeter = TotalPerimeter + triangles[i].Perimeter;
                    count1++;
                }

                if (triangles[i].Isosceles())
                {
                    TotalArea = TotalArea + triangles[i].Area;
                    count2++;
                }
            }

            AveragePerimeter = TotalPerimeter / count1;
            Console.WriteLine("Средний периметр прямоугольных труегольников: " + AveragePerimeter);

            AverageArea = TotalArea / count2;
            Console.WriteLine("Средняя площадь равнобедренных треугольников: " + AverageArea);
        }
    }
}


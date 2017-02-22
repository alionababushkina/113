using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public readonly Edge A, B, C;
        double P;
        double area;

        public Triangle(Point a, Point b, Point c)
        {

            A = new Edge(a, b);
            B = new Edge(b, c);
            C = new Edge(c, a);

            P = Perimeter;
            area = Area;
        }

        public bool TriangleExist()
        {
            if (A.Lenght + B.Lenght > C.Lenght || B.Lenght + C.Lenght > A.Lenght || A.Lenght + C.Lenght > B.Lenght)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public bool Isosceles()
        {
            return ((A.Lenght == B.Lenght) && (B.Lenght == C.Lenght) || (A.Lenght == C.Lenght));

        }

        public bool Right()
        {
            return (Math.Pow(C.Lenght, 2) == Math.Pow(A.Lenght, 2) + Math.Pow(B.Lenght, 2));

        }

        public double Perimeter
        {
            get
            {
                P = A.Lenght + B.Lenght + C.Lenght;
                //Console.WriteLine("Периметр: " + P);
                return P;
            }

        }


        public double Area
        {
            get
            {

                double p = (P / 2);
                area = Math.Sqrt(p * (p - A.Lenght) * (p - B.Lenght) * (p - C.Lenght));
                //Console.WriteLine("Площадь: " + area);
                return area;
            }
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.A == t2.A && t1.B == t2.B && t1.A == t2.B ||
                   t1.B == t2.A && t1.B == t2.A && t1.C == t2.C ||
                   t1.A == t2.A && t1.C == t2.C && t1.A == t2.C ||
                   t1.C == t2.A && t1.C == t2.C && t1.C == t2.B;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return t1.A != t2.A && t1.B != t2.B && t1.A != t2.B ||
                   t1.B != t2.A && t1.B != t2.A && t1.C != t2.C ||
                   t1.A != t2.A && t1.C != t2.C && t1.A != t2.C ||
                   t1.C != t2.A && t1.C != t2.C && t1.C != t2.B;
        }


    }

}



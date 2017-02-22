using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public readonly Point A, B;

        public Edge(Point x, Point y)
        {
            A = x;
            B = y;

            if (!(A.X == B.X && A.Y == B.Y))//проверка на существования ребра
            {
                A = x;
                B = y;
            }

        }

        public double Lenght
        {
            get
            {

                return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));

            }

        }

        
        public static bool operator ==(Edge e1, Edge e2)
        {
            return e1.A == e2.A && e1.B == e2.B ||
            e1.A == e2.B && e1.B == e2.A;
        }

        public static bool operator !=(Edge e1, Edge e2)
        {
            return e1.A != e2.A && e1.B != e2.B ||
            e1.A != e2.B && e1.B != e2.A;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fifteens
{
    class Program
    {
        static void Main(string[] args)
        {
            Game2 field = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);
            Game f1 = field.Randomize();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class ArrayButton
    {
        private int[,] button;

        public ArrayButton(int size)
        {
            button = new int[size, size];
        }

        public int this[int x, int y]//индексатор 
        {

            get
            {
                return button[x, y];
            }
            set
            {
                button[x, y] = value;
            }
        }


    }
}

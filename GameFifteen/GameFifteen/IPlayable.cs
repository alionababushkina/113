using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    interface IPlayable
    {
        int[] Randomize();
        int SizeField { get; }
        bool IsFinished { get; }
        void Shift(int value);
        int this[int val1, int val2]{ get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class Game3 : Game2
    {
        private List<int> movesHistory;



        public Game3(params int[] values)
            : base(values)
        {

            movesHistory = new List<int>();
        }


        public override void Shift(int value)
        {
            base.Shift(value);
            movesHistory.Add(value);

        }

        public int GetStep(int value)
        {
            return movesHistory[value - 1];
        }

        public void Rollback()
        {
            int lastMove = movesHistory.Last();
            movesHistory.Remove(lastMove);
            this.Shift(lastMove);
        }
    }
}



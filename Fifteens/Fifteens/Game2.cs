using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class Game2 : Game
    {
        public Game2(params int[] values)
    : base(values)
        {

        }

        public void Randomize()
        {
            int[] values = new int[this.Side * this.Side];
           

            for (int i = 0; i < this.Side; i++)
            {
                for (int j = 0; j < this.Side; j++)
                {
                    if (this[i, j].Number == 0)
                    {
                        if (this[i + 1, j].Number != 0)
                        {
                            this.Shift(this[i + 1, j].Number);
                        }
                    }
                }
            }

        }


        public bool CheckForWinningGame()
        {

            for (int i = 0; i < this.Side; i++)
            {
                for (int j = 0; j < this.Side; j++)
                {
                    if ((i != this.Side - 1) || (j != this.Side - 1))
                    {
                        if (this[i, j].Number != this[i, j + 1].Number - 1)
                        {
                            return false;
                        }
                        else if (Field[this.Side - 1, this.Side - 1].Number != 0)
                        {
                            return false;
                        }

                    }
                }
            }
            return true;
        }



    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class Game3 : Game2, IPlayable
    {
        private List<int> History;

        public Game3(params int[] values)
            : base(values)
        {
            History = new List<int>();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            History.Add(value);
        }

        public int Step(int value)
        {
            return History[value - 1];
        }

        public void Rollback()
        {
            int last = History.Last();
            History.Remove(last);
            this.Shift(last);
        }

    }

    }

        
    
  

  

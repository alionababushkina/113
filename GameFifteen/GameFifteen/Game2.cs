using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class Game2 : Game, IPlayable
    {
      public Game2(params int[] values)
            : base(values)
        {

        }
        
        public virtual int[]  Randomize()
        {

            int[] numbers = new int[side * side];

            var rand = new Random();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = rand.Next(1, numbers.Length);
                if(i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
            }

            numbers[numbers.Length - 1] = numbers.Length;

            var count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        count++;
                    }
                }
            }

            if (count % 2 != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers.Length - 1)
                    {
                        numbers[i] = numbers.Length - 2;
                    }
                    else if (numbers[i] == numbers.Length - 2)
                    {
                        numbers[i] = numbers.Length - 1;
                    }
                }
            }
            numbers[numbers.Length - 1] = 0;
            return numbers;
            
        }



        public virtual bool IsFinished
        {
            get
            {
                int[] massive = new int[side * side];
                for (int i = 0; i < side; i++)
                {
                    for (int j = 0; j < side - 1; j++)
                    {
                        if ((i != side - 1) || (j != side - 1))
                        {
                            if ((Field[i, j] != Field[i, j + 1] - 1))
                            {

                                return false;
                            }

                        }
                    }
                }
                return true;
            }
        }

        public override void Shift(int value)
        {
            base.Shift(value);
        }

        public override int SizeField
        {
            get
            {
                  return base.SizeField;
            }
        }
            
    }
}


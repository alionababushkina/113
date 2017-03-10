using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class Game2 : Game
    {
      public Game2(params int[] values)
            : base(values)
        {

        }
        
        public int[]  Randomize()
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



        public bool Success()
        {

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side - 1; j++)
                {
                    if ((i != side - 1) || (j != side - 1))
                    {
                        if ((this[i, j].Number != this[i, j + 1].Number - 1) || (Field[side - 1, side - 1].Number != 0))
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


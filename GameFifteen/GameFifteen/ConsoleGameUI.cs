using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class ConsoleGameUI
    {
        IPlayable objectIPlayable;

        public ConsoleGameUI(IPlayable objectIPlayble)
        {
            this.objectIPlayable = objectIPlayble;
        }


        public void Print()
        {
           var array = objectIPlayable;
            for (int x = 0; x < objectIPlayable.SizeField; x++)
            {
                for (int y = 0; y < objectIPlayable.SizeField; y++)
                {
                    Console.Write("{0}\t",array[x, y]);
                }
                Console.WriteLine();
            }

            
        }

        public void StartGame()
        {
            int value = 0;
            while (!objectIPlayable.IsFinished)
            {
                Console.WriteLine("Поле перед ходом");
                Print();
                Console.WriteLine("Введите число");
                value = Convert.ToInt32(Console.ReadLine());
                if ((value < 1) & (value > objectIPlayable.SizeField))
                {
                    throw new ArgumentException("Нет такого числа!");
                }
                objectIPlayable.Shift(value);
                Console.WriteLine("Поле после хода");
                Print();
            }
            Console.WriteLine("Вы выиграли!");
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameFifteen
{
    class Game
    {
        public readonly Point[] Array;
        public readonly ArrayButton Field;
        public readonly int size;
        public readonly int Length;
       
            

        public Game( params int[] value)//параметр метода, принимающий переменное кол-во аргументов
        {
    
            double lenght = Math.Sqrt(value.Length);
            size = Convert.ToInt32(lenght);

            
            if (Math.Abs(size - lenght) != 0)
            {
                throw new System.ArgumentException("Неверное заполнение поля \n");

            }

            Field = new ArrayButton(size);
            Array = new Point[value.Length];

            int m = 0;

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Field[x, y] = value[m];
                    if (m == value.Length)
                        m = 0;
                    Array[value[m]] = new Point(x, y);
                    m++;
                }
            }
          }



        internal void Print()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Console.Write(Field[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        public Point GetLocation(int value)//переданное значение
        {
            return Array[value];
        }

        private bool SearchValue(int value)
        {
            if (value < Length && value >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Shift(int value)
        {
            try
            {
                Point ValueLocation = GetLocation(value);
                int x = ValueLocation.X;
                int y = ValueLocation.Y;

                Point NullLocation = GetLocation(0);
                int x0 = NullLocation.X;
                int y0 = NullLocation.Y;

                Point temp = new Point(-1, -1);
                if (Math.Abs(x - x0) == 1 && Math.Abs(y - y0) == 0 ||
                Math.Abs(y - y0) == 1 && Math.Abs(x - x0) == 0)
                {
                    Field[x, y] = 0;
                    Field[x0, y0] = value;

                    temp = Array[value];
                    Array[0] = Array[value];
                    Array[value] = temp;
                }
                else
                {
                   // Console.WriteLine("Невозможный ход");
                }
            }
            catch
            {
                //Console.WriteLine("Значения нет!");
            }
              }

       public bool EndGame()
        {
            bool temp = false;
            int value = 1;
            for (int x=0; x < size; x++)
            {
                for(int y=0; y <size; y++)
                {
                    if (Field[x,y] == value)
                    {
                        temp = true;
                        value++;
                        if (value == Length)
                        {
                            value = 0;
                        }
                       
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return temp;

        }

       

        public static Game FromCSV(string file)
        {
            string[] csv = File.ReadAllLines(file);
            List<int> list = new List<int>();
            for (int i = 0; i < csv.Count(); i++)
            {
                for (int j = 0; j < csv[i].Split(';').Count(); j++)
                {
                    list.Add(Convert.ToInt32(csv[i].Split(';')[j]));
                }
            }
           
            return new Game(list.ToArray<int>());
        }
    }
}
       

        
    



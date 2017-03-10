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
        public readonly int side;
        public readonly int size;
        public readonly Value[,] Field;
        public readonly int Length;
        public Dictionary<int, Point> Dictionary;


        public Game(params int[] value)//параметр метода, принимающий переменное кол-во аргументов
        {
            Dictionary = new Dictionary<int, Point>();
            double lenght = Math.Sqrt(value.Length);
            size = Convert.ToInt32(lenght);
            
            if (Math.Abs(size - lenght) != 0) 
            {
                throw new System.ArgumentException("Неверное заполнение поля \n ");

            }
            
            int m = 0;
            Field = new Value[side, side];
           

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Field[i, j] = new Value(value[m]);
                    Dictionary.Add(value[m], new Point(i, j));
                    m++;
                }
            }
        }

      

        public Value this[int val1, int val2]
        {
            get
            {
                return Field[val1, val2];
            }
            set
            {
                Field[val1, val2] = value;
            }
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

        public Point GetLocation(int value)
        {
            return Dictionary[value];
        }


        public virtual void Shift(int value)
        {
            if (Dictionary[value] - Dictionary[0] == 1)
            {
                Point positionNull = Dictionary[0];
                this[Dictionary[0].X, Dictionary[0].Y] = new Value(value);
                this[Dictionary[value].X, Dictionary[value].Y] = new Value(0);
                Dictionary[0] = Dictionary[value];
                Dictionary[value] = positionNull;
            }

            else throw new ArgumentException("Неверное значение ");
                // Console.WriteLine("Невозможный ход");
            }
        }

}
    //public static Game FromCSV(string file)
    //    {
    //        string[] csv = File.ReadAllLines(file);
    //        List<int> list = new List<int>();
    //        for (int i = 0; i < csv.Count(); i++)
    //        {
    //            for (int j = 0; j < csv[i].Split(';').Count(); j++)
    //            {
    //                list.Add(Convert.ToInt32(csv[i].Split(';')[j]));
    //            }
    //        }
           
    //        return new Game(list.ToArray<int>());
    //    }
    

   
       

        
    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fifteens
{
    class Game
    {
        public Value[,] Field;

        public readonly int Side;
        public Dictionary<int, ValueCoordiante> Dictionary;




        public Game(params int[] values)
        {
            int count = 0;
            Dictionary = new Dictionary<int, ValueCoordiante>();

            Side = (int)Math.Sqrt(values.Length);

            if (!CheckFieldCreation(values.Length))
            {
                throw new ArgumentException("Невозмжно создать поле такого размера.");
            }

            if (!CheckUniqueValues(values))
            {
                throw new ArgumentException("Встречаются одинаковые числа.");
            }
            if (CheckNegativeNumbers(values))
            {
                throw new ArgumentException("Есть отрицательные числа.");
            }


            Field = new Value[Side, Side];

            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    Field[i, j] = new Value(values[count]);
                    Dictionary.Add(values[count], new ValueCoordiante(i, j));
                    count++;
                }
            }

        }


        public Value this[int index1, int index2]
        {
            get
            {
                return Field[index1, index2];
            }
            set
            {
                Field[index1, index2] = value;
            }
        }


        public ValueCoordiante GetLocation(int value)
        {
            return Dictionary[value];
        }



        public virtual void Shift(int value)
        {

            if (Dictionary[value] - Dictionary[0] == 1)
            {
                ValueCoordiante positionZero = Dictionary[0];
                this[Dictionary[0].X, Dictionary[0].Y] = new Value(value);
                this[Dictionary[value].X, Dictionary[value].Y] = new Value(0);
                Dictionary[0] = Dictionary[value];
                Dictionary[value] = positionZero;
            }
            else throw new ArgumentException("Невозможно передвинуть фишку");
        }



        private bool CheckFieldCreation(int size)
        {
            return ((Math.Sqrt(size) % 1) == 0);
        }

        private bool CheckUniqueValues(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                temp = mass[i];
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[j] == temp)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool CheckNegativeNumbers(int[] values)
        {
            foreach (int i in values)
            {
                return values[i] < 0;
            }
            return true;
        }



    }
}
    


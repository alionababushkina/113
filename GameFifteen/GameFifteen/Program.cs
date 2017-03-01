using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Game NewGame = new Game(1, 2, 3, 4, 5, 6, 7, 8, 0);
            Game game = Game.FromCSV("Книга1.csv");

            while (1 == 1)
            {
                Console.Clear();
                NewGame.Print();

                Console.Write("Введите число ");
                

                int value = Convert.ToInt32(Console.ReadLine());
                NewGame.Shift(value);
                NewGame.Print();
            }
            
            }
 
        }
        }
    


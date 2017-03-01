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
            NewGame.Print();

            while (1 == 1)
            {
                Console.Write("Введите число ");
                

                int value = Convert.ToInt32(Console.ReadLine());
                NewGame.Shift(value);
                NewGame.Print();
            }
            
            }
 
        }
        }
    


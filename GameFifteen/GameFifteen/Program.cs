using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameFifteen
{
    class Program
    {
        static void Print(Game NewGame)
        {
            for (int x = 0; x < NewGame.side; x++)
            {
                for (int y = 0; y < NewGame.side; y++)
                {
                    Console.Write(NewGame.Field[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {


            Game2 NewGame = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);
            //Game game = Game.FromCSV("Книга1.csv");

            NewGame.Randomize();
            Print(NewGame);
            Console.Clear();
            Console.ReadKey();

        }
    }
}
       
   

       
    
  
    


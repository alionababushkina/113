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
        //public void Print(Game NewGame)
        //{
        //    for (int x = 0; x < NewGame.side; x++)
        //    {
        //        for (int y = 0; y < NewGame.side; y++)
        //        {
        //            Console.Write(NewGame.Field[x, y] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        static void Main(string[] args)
        {


            Game2 field_2 = new Game2(1, 5, 8, 4, 2, 3, 11, 15, 9, 6, 10, 7, 12, 14, 13);
            Game3 field_3 = new Game3(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
            //Game game = Game.FromCSV("Книга1.csv");

            ConsoleGameUI obj = new ConsoleGameUI(field_2);
            obj.StartGame();
        }
    }
}
       
   

       
    
  
    


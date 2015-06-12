using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var games = new Games();

            while (true)
            {
                switch (ShowMenu())
                {
                    case "L":

                        
                        ListGames(games);
                        break;
                    case "Q":
                        return;
                }
            }

        }

        private static void ListGames(Games games)
        {
            foreach (var product in games.AllProducts())
            {
                Console.WriteLine(product);
            }
        }

        public static string ShowMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("L) List Games");
            Console.WriteLine("Q) Quit Game");

           return Console.ReadLine().Trim().ToUpper();
        }

      
    }
}

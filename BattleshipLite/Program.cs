using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by snippetsBySam");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static Player CreatePlayer()
        {
            Position playerStartPosition = new Position(0, 0);
            ConsoleColor playerColor = ConsoleColor.Green;
            Player player = new Player(playerStartPosition, playerColor);
            return player;
        }
    }
}


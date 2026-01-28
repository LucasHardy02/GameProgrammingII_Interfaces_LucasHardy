using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Player(Position startPosition, ConsoleColor playerColor)
    {
        public ConsoleColor _playerColor = ConsoleColor.Green;
        public Position _playerPosition = new Position();

        playerColor = _playerColor;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Player
    {
        public static ConsoleColor _playerColor = ConsoleColor.Green;
        public static Position _playerPosition = new Position(0,0);

        public Player(Position position, ConsoleColor consoleColor)
        {

            _playerPosition._x = position._x;
            _playerPosition._y = position._y;
            _playerColor = consoleColor;
        }

        public Player player = new Player(_playerPosition, _playerColor);
    }
}

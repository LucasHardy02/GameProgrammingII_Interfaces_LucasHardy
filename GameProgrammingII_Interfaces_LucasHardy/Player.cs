using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Player
    {
        public ConsoleColor _playerColor = ConsoleColor.Green;
        public Position _playerPosition = new Position(0,0);

        public int _gameWidth = 20;
        public int _gameHeight = 15;
        public Player(Position position, ConsoleColor consoleColor)
        {
            _playerPosition._x = position._x;
            _playerPosition._y = position._y;
            _playerColor = consoleColor;
        }
        public void OnPlayerMove(ConsoleKey movementKey)
        {
         
            if (movementKey == ConsoleKey.W)
            {
                _playerPosition._y--;
            }
            else if (movementKey == ConsoleKey.S)
            {
                _playerPosition._y++;
            }
            else if (movementKey == ConsoleKey.A)
            {
                _playerPosition._x--;
            }
            else if (movementKey == ConsoleKey.D)
            {
                _playerPosition._x++;
            }
            if (_playerPosition._x < 0)
            {
                _playerPosition._x = 0;
            }
            if (_playerPosition._y < 0)
            {
                _playerPosition._y = 0;
            }
            if (_playerPosition._x > _gameWidth)
            {
                _playerPosition._x = _gameWidth;
            }
            if (_playerPosition._y > _gameHeight)
            {
                _playerPosition._y = _gameHeight;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Enemy : Player
    {
        public ConsoleColor _enemyColor = ConsoleColor.Red;
        public Position _enemyPosition = new Position(5, 5);
        public Enemy(Position position, ConsoleColor consoleColor) : base(position, consoleColor)
        {
            _enemyPosition._x = position._x;
            _enemyPosition._y = position._y;
            _enemyColor = consoleColor;
        }
        public IMoveStrategy _moveStrategy;
        public void OnEnemyMove(IMoveStrategy moveStrat, Position playerPos)
        {
            _playerPosition = playerPos;
            _moveStrategy = moveStrat;
            if (moveStrat != null)
            {
                _enemyPosition = _moveStrategy.OnEnemyMove(_enemyPosition, playerPos);
            }
            if (_enemyPosition._x < 0)
            {
                _enemyPosition._x = 0;
            }
            if (_enemyPosition._y < 0)
            {
                _enemyPosition._y = 0;
            }
            if (_enemyPosition._x > _gameWidth)
            {
                _enemyPosition._x = _gameWidth;
            }
            if (_enemyPosition._y > _gameHeight)
            {
                _enemyPosition._y = _gameHeight;
            }
        }
    }
}

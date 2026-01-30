using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class Enemy : Player
    {
        public static ConsoleColor _enemyColor = ConsoleColor.Red;
        public static Position _enemyPosition = new Position(5,5);

        public Enemy(Position position, ConsoleColor consoleColor) : base(position, consoleColor)
        {
            _enemyPosition._x = position._x;
            _enemyPosition._y = position._y;
            _enemyColor = consoleColor;
        }
        public static Enemy enemy = new Enemy(_enemyPosition, _enemyColor);

        public IMoveStrategy _moveStrategy;

        
        
    }
}

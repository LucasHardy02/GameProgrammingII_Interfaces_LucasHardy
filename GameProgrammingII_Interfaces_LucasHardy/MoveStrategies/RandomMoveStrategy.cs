using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class RandomMoveStrategy : IMoveStrategy
    {
        public Position OnEnemyMove(Position currentEnemyPos, Position currentPlayerPos)
        {
            Random random = new Random();
            int randomValue = random.Next(0, 4);
            if (randomValue == 0)
            {
                currentEnemyPos._x++;
            }
            else if (randomValue == 1)
            {
                currentEnemyPos._x--;
            }
            else if (randomValue == 2)
            {
                currentEnemyPos._y++;
            }
            else if (randomValue == 3)
            {
                currentEnemyPos._y--;
            }
            return currentEnemyPos;
        }
    }
}

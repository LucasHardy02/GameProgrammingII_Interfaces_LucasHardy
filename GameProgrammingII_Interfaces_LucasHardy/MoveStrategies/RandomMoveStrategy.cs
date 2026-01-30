using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class RandomMoveStrategy : IMoveStrategy
    {
        public Position EnemyMove(Position currentEnemyPos, Position currentPlayerPos)
        {
            Random random = new Random();
            random.Next(0, 4);


            if (random.Next() == 0)
            {
                currentEnemyPos._x++;
            }
            else if (random.Next() == 1)
            {
                currentEnemyPos._x--;
            }
            else if (random.Next() == 2)
            {
                currentEnemyPos._y++;
            }
            else if (random.Next() == 3)
            {
                currentEnemyPos._y--;
            }
            return currentEnemyPos;
        }
    }
}

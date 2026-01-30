using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class PassiveMoveStrategy : IMoveStrategy
    {
        public Position EnemyMove(Position currentEnemyPos, Position currentPlayerPos)
        {

            if (currentEnemyPos._x < currentPlayerPos._x)
            {
                currentEnemyPos._x--;
            }
            else if (currentEnemyPos._x > currentPlayerPos._x)
            {
                currentEnemyPos._x++;
            }
            else if (currentEnemyPos._y < currentPlayerPos._y)
            {
                currentEnemyPos._y--;
            }
            else if (currentEnemyPos._y > currentPlayerPos._y)
            {
                currentEnemyPos._y++;
            }
            return currentEnemyPos;
        }
    }
}

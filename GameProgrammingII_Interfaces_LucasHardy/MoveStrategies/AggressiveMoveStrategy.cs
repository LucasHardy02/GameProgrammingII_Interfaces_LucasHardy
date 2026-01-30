using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingII_Interfaces_LucasHardy
{
    internal class AggressiveMoveStrategy : IMoveStrategy
    {
        public void EnemyMove(Position currentEnemyPos, Position currentPlayerPos)
        {

            if (currentEnemyPos._x < Player._playerPosition._x)
            {
                currentEnemyPos._x++;
            }
            else if (currentEnemyPos._x > Player._playerPosition._x)
            {
                currentEnemyPos._x--;
            }
            else if (currentEnemyPos._y < Player._playerPosition._y)
            {
                currentEnemyPos._y++;
            }
            else if (currentEnemyPos._y > Player._playerPosition._y)
            {
                currentEnemyPos._y--;
            }
            return;
            
        }
    }
}

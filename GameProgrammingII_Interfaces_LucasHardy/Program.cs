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
        static bool _gameRunning = true;
        static bool _enemyMoving = false;

        static bool _playerTurn = true;
        static bool _enemyTurn = false;

        static Position _enemySpawn;
        static Position _playerSpawn;

        static Player Lucas;
        static Enemy Zander;

        public static ConsoleKey _movementSelection;
        static void Main(string[] args)
        {
            _playerSpawn = new Position(0, 0);
            Lucas = new Player(_playerSpawn, ConsoleColor.Green);
            _enemySpawn = new Position(5, 5);
            Zander = new Enemy(_enemySpawn, ConsoleColor.Red);
            while (_gameRunning)
            {
                if (_movementSelection == ConsoleKey.M)
                {
                    _enemyMoving = true;
                }
                else if (_movementSelection == ConsoleKey.N)
                {
                    _enemyMoving = false;
                }

                DrawGame();
                ShowHUD();
                if (_playerTurn)
                {
                    PlayerInput();
                    Lucas.OnPlayerMove(_movementSelection);
                    _playerTurn = false;
                    _enemyTurn = true;
                }
                else if (_enemyTurn)
                {
                    EnemyMovement();
                    Zander.OnEnemyMove(Zander._moveStrategy, Lucas._playerPosition);
                    _enemyTurn = false;
                    _playerTurn = true;
                }

                


               

            }
        }
        static void PlayerInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            _movementSelection = keyInfo.Key;
        }
        static void DrawGame()
        {
            Console.Clear();
            Console.SetCursorPosition(Zander._enemyPosition._x, Zander._enemyPosition._y);
            Console.ForegroundColor = Zander._enemyColor;
            Console.Write("X");
            Console.SetCursorPosition(Lucas._playerPosition._x, Lucas._playerPosition._y);
            Console.ForegroundColor = Lucas._playerColor;
            Console.Write("O");
            Console.ResetColor();
        }
        static void EnemyMovement()
        {
            if (_enemyMoving == true)
            {
                if (_movementSelection == ConsoleKey.I)
                {
                    Zander._moveStrategy = new AggressiveMoveStrategy();
                }
                else if (_movementSelection == ConsoleKey.O)
                {
                    Zander._moveStrategy = new PassiveMoveStrategy();
                }
                else if (_movementSelection == ConsoleKey.P)
                {
                    Zander._moveStrategy = new RandomMoveStrategy();
                }
            }
        }
        static void ShowHUD()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Use W,A,S,D to move the player (O)");
            Console.WriteLine("Please Press M to enable enemy movement, N to disable it");
            Console.WriteLine("Once enemy movement is enabled, press I for Aggressive Enemy movement, O for Passive movement, or P for Random movement");
        }
    }
}


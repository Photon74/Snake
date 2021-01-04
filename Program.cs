using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            GameField gameField = new GameField();
            gameField.DrawInterface();

            Food food = new Food(gameField.GameFieldWidth, gameField.GameFieldHeigth);
            food.DrawFood();
            food.DrawFood();
            food.DrawFood();
            food.DrawFood();
            food.DrawFood();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 4, Direction.Right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.A: snake.direction = Direction.Left;
                            break;
                        case ConsoleKey.D: snake.direction = Direction.Right;
                            break;
                        case ConsoleKey.W: snake.direction = Direction.Up;
                            break;
                        case ConsoleKey.S: snake.direction = Direction.Down;
                            break;
                    }
                }
                Thread.Sleep(300);
                snake.Move();
            }
        }
    }
}

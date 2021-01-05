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
            gameField.DrawGameField();

            Food food = new Food(gameField.GameFieldWidth, gameField.GameFieldHeigth);
            food.CreateNewFood();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 4, Direction.Right);
            snake.Draw();
            

            while (true)
            {
                if (snake.IsHitItself() || gameField.IsHitedBy(snake)) break;
                if (snake.IsEating(food))
                {
                    food.CreateNewFood();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    snake.GetMovingDirection(key.Key);
                }
                Thread.Sleep(300);
            }
        }
    }
}

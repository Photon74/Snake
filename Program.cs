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
            gameField.DrawWalls();

            Food food = new Food(gameField.GameFieldWidth, gameField.GameFieldHeigth);
            food.DrawNewFood();

            Snake snake = new Snake();
            snake.Draw();

            while (true)
            {
                if (snake.IsHittingItself() || gameField.IsHitedBy(snake)) break;

                if (snake.IsEating(food))
                    food.DrawNewFood();
                else
                    snake.Move();

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    snake.GetMovingDirection(key.Key);
                }

                Thread.Sleep(200);
            }
            WriteGameOver();
            Console.ReadLine();
        }

        static void WriteGameOver()
        {
            int xOffset = 30;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("==============================", xOffset-1, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Автор: Александр Колодинский", xOffset, yOffset++);
            WriteText("==============================", xOffset-1, yOffset++);
        }

        static void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}

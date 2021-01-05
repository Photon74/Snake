using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameField
    {
        public int GameFieldWidth { get; }
        public int GameFieldHeigth { get; }
        public List<Figure> walls;
        public GameField()
        {
            GameFieldWidth = Console.WindowWidth - 2;
            GameFieldHeigth = Console.WindowHeight - 2;
            Console.SetBufferSize(GameFieldWidth + 2, GameFieldHeigth + 2);
            Console.CursorVisible = false;
        }

        public void DrawGameField()
        {
            walls = new List<Figure>();
            HorizontLine upWall = new HorizontLine(0, GameFieldWidth, 0, '+');
            HorizontLine downWall = new HorizontLine(0, GameFieldWidth, GameFieldHeigth, '+');
            VerticalLine leftWall = new VerticalLine(0, GameFieldHeigth, 0, '+');
            VerticalLine rightWall = new VerticalLine(0, GameFieldHeigth, GameFieldWidth, '+');
            walls.Add(upWall);
            walls.Add(downWall);
            walls.Add(leftWall);
            walls.Add(rightWall);
            foreach (Figure wall in walls)
            {
                wall.Draw();
            }
        }

        public bool IsHitedBy(Figure figure)
        {
            foreach (Figure wall in walls)
            {
                if (wall.IsHitedBy(figure)) return true;
            }

            return false;
        }
    }
}

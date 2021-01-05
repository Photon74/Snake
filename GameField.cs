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
        private List<Figure> walls;

        public GameField() // Определяются размеры игрового поля
        {
            GameFieldWidth = Console.WindowWidth - 2;
            GameFieldHeigth = Console.WindowHeight - 2;
            Console.SetBufferSize(GameFieldWidth + 2, GameFieldHeigth + 2);
            Console.CursorVisible = false;
        }

        public void DrawWalls() // Создаются и отрисовываются границы игрового поля
        {
            HorizontLine upWall = new HorizontLine(0, GameFieldWidth, 0, '+');
            HorizontLine downWall = new HorizontLine(0, GameFieldWidth, GameFieldHeigth, '+');
            VerticalLine leftWall = new VerticalLine(0, GameFieldHeigth, 0, '+');
            VerticalLine rightWall = new VerticalLine(0, GameFieldHeigth, GameFieldWidth, '+');
            walls = new List<Figure> {upWall, downWall, leftWall, rightWall};
            foreach (Figure wall in walls)
            {
                wall.Draw();
            }
        }

        public bool IsHitedBy(Figure snake) // Ударилась ли змейка об стену (границу игрового поля)
        {
            foreach (Figure wall in walls)
            {
                if (wall.IsHittedBy(snake)) return true;
            }
            return false;
        }
    }
}

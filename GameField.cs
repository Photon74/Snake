using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameField
    {
        public int GameFieldWidth { get; set; }
        public int GameFieldHeigth { get; set; }
        public GameField()
        {
            GameFieldWidth = Console.WindowWidth - 2;
            GameFieldHeigth = Console.WindowHeight - 2;

            Console.SetBufferSize(GameFieldWidth + 2, GameFieldHeigth + 2);
            Console.CursorVisible = false;
        }

        public void DrawInterface()
        {
            HorizontLine upLine = new HorizontLine(0, GameFieldWidth, 0, '+');
            HorizontLine downLine = new HorizontLine(0, GameFieldWidth, GameFieldHeigth, '+');
            VerticalLine leftLine = new VerticalLine(0, GameFieldHeigth, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, GameFieldHeigth, GameFieldWidth, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        private readonly int gameFieldWidth;
        private readonly int gameFieldHeigth;
        private readonly Random random = new Random();
        private Point food;

        public Food(int gameFieldWidth, int gameFieldHeigth)
        {
            this.gameFieldWidth = gameFieldWidth;
            this.gameFieldHeigth = gameFieldHeigth;
        }

        public void DrawFood()
        {
            int x = random.Next(2, gameFieldWidth);
            int y = random.Next(2, gameFieldHeigth);
            food = new Point(x, y, '$');
            food.DrawPoint();
        }
    } 
}

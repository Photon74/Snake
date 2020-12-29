using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yStart, int yEnd, int x, char sym)
        {
            pointsList = new List<Point>();
            for (int y = yStart; y <= yEnd; y++)
            {
                pointsList.Add(new Point(x, y, sym));
            }
        }
    }
}

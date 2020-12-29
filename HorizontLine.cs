using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine : Figure
    {
        public HorizontLine(int xStart, int xEnd, int y, char sym)
        {
            pointsList = new List<Point>();
            for (int x = xStart; x <= xEnd; x++)
            {
                pointsList.Add(new Point(x, y, sym)); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pointsList;
        public void Draw()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }
    }
}

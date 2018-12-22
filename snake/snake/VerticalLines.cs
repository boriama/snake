using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLines: Figure
    {
        
        public VerticalLines(int x, int yHight, int yLow, char sim)
        {
            pList = new List<Point>();
            for (int y = yHight; y <= yLow; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
       
    }
}

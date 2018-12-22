using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLines
    {
        List<Point> pList;
        public VerticalLines(int x, int yHight, int yLow, char sim)
        {
            pList = new List<Point>();
            for (int y = yHight; y <= yLow; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

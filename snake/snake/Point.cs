using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public void Reset(Point p )
        {
            p = new Point(0,0,'0');
        }

        public void Mowe(Point p, int dx, int dy )
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public Point(int _x,int _y,char _sim )
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}

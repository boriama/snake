using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
       
        static void Main(string[] args)
        {

            


            HorisontalLine upLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine downLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLines rightLine = new VerticalLines(0, 0, 24, '+');
            VerticalLines leftLine = new VerticalLines(78, 0, 24, '+');
            upLine.Drow();
            downLine.Drow();
            rightLine.Drow();
            leftLine.Drow();
            Console.ReadLine();
        }
    }
}

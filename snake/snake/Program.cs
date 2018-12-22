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

           HorisontalLine lineH = new  HorisontalLine(5, 10, 7,'$');
            lineH.Drow();
            VerticalLines lineV = new VerticalLines(6, 5, 10, '@');
            lineV.Drow();

            Console.ReadLine();
        }
    }
}

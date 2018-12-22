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

           HorisontalLine line = new  HorisontalLine(5, 10, 7,'$');
            line.Drow();


            Console.ReadLine();
        }
    }
}

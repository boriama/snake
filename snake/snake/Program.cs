using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Draw(int x,int y,string sim)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sim);
        }
        static void Main(string[] args)
        {
            Draw(1, 2, "@");
            Console.ReadLine();
        }
    }
}

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
         List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(4);
            numList.Add(9);
            foreach(int i in numList)
            {
                Console.WriteLine(i);

            }


            Point p1 = new Point(5 ,6, '#');
            Point p2 = new Point(6, 7, '$');
            Point p3 = new Point(2, 3, '*');
            Point p4 = new Point(9, 2, '%');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            pList.RemoveAt(0);
           

            Console.ReadLine();
        }
    }
}

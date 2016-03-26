using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trial_snake;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            p1.Draw();

            Point p2 = new Point(4, 4, '#');
            p2.Draw();

            Console.ReadKey();
        }

    }
}


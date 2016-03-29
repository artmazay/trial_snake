using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using trial_snake;
//using Snake;

namespace trial_snake
{
    class Program
    {
        static void Main(string[] args)
        {

            VerticalLine line1 = new VerticalLine(6, 12, 3, '.');
            //Draw(line1);

            Point p = new Point(2, 3, '*');
            Figure fSnake = new Snake(p, 7, Direction.RIGHT);
            //Draw(fSnake);
            Snake sn = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(4, 9, 5, ',');
            //Draw(h1);

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(line1);
            figures.Add(h1);

            foreach(var t in figures)
            {
                t.Drow();
            }
            Console.ReadKey();
        }
        static void Draw(Figure figure)
        {
            figure.Drow();
        }
    }
}


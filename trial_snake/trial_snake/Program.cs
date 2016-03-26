using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 7, y1 = 11, x2 = 4, y2 = 5;
            char symv = '*', sym = '"';
            for (int i = 0; i <= 10; i++)
            {
                Draw(x1, y1--, sym);
            }
            Console.ReadKey();
        }

        private static void Draw(int x1, int y1, char symv)
        {
            Console.SetCursorPosition(x1, y1);
            Console.WriteLine(symv);
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_snake
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            foreach(Point p in pList)
            {
                p.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
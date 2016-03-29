﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            pList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                direction = _direction;
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey info)
        {
            if (info == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (info == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (info == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (info == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
    }
}

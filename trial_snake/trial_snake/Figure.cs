using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_snake
{
    class Figure
    {
        protected List<Point>pList;

        public virtual void Drow()
        {
            foreach (Point n in pList)
            {
                n.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHits(p))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHits(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            } 
            return false;
        }
    }
}

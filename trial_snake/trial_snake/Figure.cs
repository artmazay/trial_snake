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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class CompSort : IComparer<Circle, Square>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x.GetArea() > y.GetArea()) { return 1; }
            else if (x.GetArea() < y.GetArea()) { return -1; }
            else { return 0; }
        }

        public int Compare(Square x, Square y)
        {
            if (x.GetArea() > y.GetArea()) { return 1; }
            else if (x.GetArea() < y.GetArea()) { return -1; }
            else { return 0; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ShapeAreaComparer : IComparable<IShape>
    {
        //CompareTo - предназначен для сравнения текущего объекта с переданным. Т.е. area1 = должно быть this.
        public int CompareTo(IShape area1, IShape area2)
        {
            int cmpVal = area1.GetArea().CompareTo(area2.GetArea());

            return cmpVal;
        }
    }
}

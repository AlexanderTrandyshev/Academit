using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : IShape
    {
        public double Width
        {
            get;
            set;
        }

        public double Heigth
        {
            get;
            set;
        }

        public Rectangle(double width, double hiegth)
        {
            Width = width;
            Heigth = hiegth;
        }

        public double GetArea()
        {
            return Width * Heigth;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Heigth);
        }
    }
}

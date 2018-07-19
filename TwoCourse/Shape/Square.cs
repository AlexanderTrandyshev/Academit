using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : IShape
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

        public Square(double sideLength)
        {
            Width = sideLength;
        }

        public double GetArea()
        {
            return Math.Pow(Width, 2);
        }

        public double GetPerimeter()
        {
            return 4 * Width;
        }
    }
}

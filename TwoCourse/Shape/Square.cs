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

        public override string ToString()
        {
            return "Квадрат";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(null, obj) || obj.GetType() != GetType())
            {
                return false;
            }

            Square s = (Square)obj;

            return s.Heigth == Heigth && s.Width == Width;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;

            hash = prime * hash + Width.GetHashCode();
            hash = prime * hash + Heigth.GetHashCode();

            return hash;
        }
    }
}

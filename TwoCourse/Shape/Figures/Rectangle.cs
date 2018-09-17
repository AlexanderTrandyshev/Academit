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

        public override string ToString()
        {
            return "Прямоугольник";
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

            Rectangle r = (Rectangle)obj;

            return r.Width == Width && r.Heigth == Heigth;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : IShape
    {
        private double radius;

        public double Width
        {
            get { return 2 * radius; }
            set { radius = value; }
        }

        public double Heigth
        {
            get { return 2 * radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}

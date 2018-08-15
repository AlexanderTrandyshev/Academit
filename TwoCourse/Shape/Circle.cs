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

        public override string ToString()
        {
            return "Окружность";
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

            Circle c = (Circle)obj;

            return c.radius == radius;
        }

        public override int GetHashCode()
        {
            const int prime = 37;
            int hash = 1;

            hash = prime * hash + Width.GetHashCode();

            return hash;
        }
    }
}

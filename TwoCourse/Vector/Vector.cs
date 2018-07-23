using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private double size;
        private double[] componentsVector;

        public Vector(double n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размер вектора не может быть <= 0"); ;
            }
            else
            {
                size = n;
            }

        }

        public Vector(Vector vector)
        {

        }

        public Vector(double[] arrayComponetsVector)
        {

        }

        public Vector(double n, double[] arrayComponetsVector)
        {

        }

        public double GetSize(Vector vector)
        {
            return 0;
        }
    }
}

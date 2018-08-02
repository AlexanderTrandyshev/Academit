using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class MethodsVector
    {
        private double size;
        private double[] vector;

        public MethodsVector(double n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размер вектора не может быть <= 0");
            }
            else
            {
                size = n;
            }
        }

        public MethodsVector(MethodsVector vector)
        {
        }

        public MethodsVector(double[] vector)
        {
            for(int i = 0; i < vector.Length; ++i)
            {
                this.vector[i] = vector[i];
            }
        }

        public MethodsVector(double n, double[] arrayComponetsVector)
        {
            for (int i = 0; i < arrayComponetsVector.Length; ++i)
            {
                if (arrayComponetsVector.Length < n)
                {
                    vector[i] = 0;
                }
                else
                {
                    vector[i] = arrayComponetsVector[i];
                }
            }
        }

        public double GetSize(MethodsVector vector)
        {
            return size;
        }

        public override string ToString()
        {
            return string.Join(",", vector);
        }
    }
}

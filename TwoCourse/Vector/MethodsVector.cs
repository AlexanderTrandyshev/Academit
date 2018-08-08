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

        public MethodsVector(double size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размер вектора не может быть <= 0");
            }
            else
            {
                vector = null;
                this.size = size;
            }
        }

        public MethodsVector(MethodsVector vector)
        {
            size = vector.size;
            this.vector = vector.vector;
        }

        public MethodsVector(double[] vector)
        {
            for(int i = 0; i < vector.Length; ++i)
            {
                this.vector[i] = vector[i];
            }
        }

        public MethodsVector(double sizeArray, double[] arrayComponetsVector)
        {
            for (int i = 0; i < arrayComponetsVector.Length; ++i)
            {
                if (arrayComponetsVector.Length < sizeArray && i > sizeArray)
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

        //TODO угол неизвестен. 
        public double AdditionVectors(MethodsVector vector)
        {
            return Math.Sqrt(Math.Pow(size, 2) + Math.Pow(vector.size, 2) - 2 * size * vector.size * Math.Cos());
        }
    }
}

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
        private double[] component;

        public MethodsVector(double size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Размер вектора не может быть <= 0");
            }
            else
            {
                component = null;
                this.size = size;
            }
        }

        public MethodsVector(MethodsVector vector)
        {
            size = vector.size;
            this.component = vector.component;
        }

        public MethodsVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                this.component[i] = vector[i];
            }
        }

        public MethodsVector(double sizeArray, double[] arrayComponetsVector)
        {
            for (int i = 0; i < arrayComponetsVector.Length; ++i)
            {
                if (arrayComponetsVector.Length < sizeArray && i > sizeArray)
                {
                    component[i] = 0;
                }
                else
                {
                    component[i] = arrayComponetsVector[i];
                }
            }
        }

        public double GetSize(MethodsVector vector)
        {
            return size;
        }

        public override string ToString()
        {
            return string.Join(",", component);
        }

        //TODO нет полной реализации
        public double AdditionVectors(MethodsVector vector)
        {
            List<double> newComponent = new List<double>();

            for (int i = 0; i < vector.component.Length; ++i)
            {

                //TODO компоненты меньшей дленны должны заполняться "0" 
                if (vector.component.Length < component.Length)
                {
                    newComponent.Add(component[i] + vector.component[i]);
                }
                else
                {
                    newComponent.Add(component[i]);
                }
            }


            return new MethodsVector();
        }
    }
}

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
                for (int i = 0; i < component.Length; ++i)
                {
                    component[i] = 0;
                }
                this.size = size;
            }
        }

        public MethodsVector(MethodsVector vector)
        {
            size = vector.size;
            Array.Copy(component ,vector.component, vector.component.Length);
        }
         
        public MethodsVector(double[] valuesArray)
        {
            // TODO Нужно не создавать копию, а сразу дополнить значениями из массива?
            Array.Copy(component, valuesArray, valuesArray.Length);
        }

        public MethodsVector(double sizeArray, double[] valuesArray)
        {
            for (int i = 0; i < valuesArray.Length; ++i)
            {
                if (valuesArray.Length < sizeArray && i > sizeArray)
                {
                    component[i] = 0;
                }
                else
                {
                    component[i] = valuesArray[i];
                }
            }
        }

        public override string ToString()
        {
            string lineComponent = string.Join(",", component);

            StringBuilder sb = new StringBuilder();
            sb.Append("{ ")
              .Append(lineComponent)
              .Append(" }");

            string result = sb.ToString();

            return result;
        }

        // TODO Size - что происходит с этим значением? Нет конструктора создания обычного объекта.
        public MethodsVector AdditionVectors(MethodsVector vector)
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

            return new MethodsVector(newComponent.ToArray());
        }
        // TODO Size - что происходит с этим значением? Нет конструктора создания обычного объекта.
        public MethodsVector SubtractionVectors(MethodsVector vector)
        {
            List<double> newComponent = new List<double>();

            for (int i = 0; i < vector.component.Length; ++i)
            {

                //TODO компоненты меньшей дленны должны заполняться "0" 
                if (vector.component.Length < component.Length)
                {
                    newComponent.Add(component[i] - vector.component[i]);
                }
                else
                {
                    newComponent.Add(component[i]);
                }
            }

            return new MethodsVector(newComponent.ToArray());
        }
        // Плохой конструктор - зануляет все компоненты вектора.
        public MethodsVector MultiplicationByScalar(double number)
        {
            double newSize = size * number;
            return new MethodsVector(newSize);
        }
        
        public MethodsVector TurnVector(MethodsVector vector)
        {
            for (int i = 0; i < vector.component.Length; ++i)
            {
                vector.component[i] *= -1;
            }

            return new MethodsVector(vector.size, vector.component);
        }

        public double GetSize(MethodsVector vector)
        {
            return vector.size;
        }

        public void SetComponentVector(double value, int index)
        {
            component.SetValue(value, index);
        }

        public double GetComponentVector(int index)
        {
            return Convert.ToDouble(component.GetValue(index));
        }
    }
}

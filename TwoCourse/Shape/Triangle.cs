using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : IShape
    {
        private double x1;
        private double x2;
        private double x3;

        private double y1;
        private double y2;
        private double y3;

        public double Width
        {
            get {return GetMaxNumber(x1, x2, x3) - GetMinNumber(x1, x2, x3);}

            set
            {
                x1 = value;
                x2 = value;
                x3 = value;
            }
        }

        public double Heigth
        {
            get {return GetMaxNumber(y1, y2, y3) - GetMinNumber(y1, y2, y3);}

            set
            {
                y1 = value;
                y2 = value;
                y3 = value;
            }
        }

        public Triangle (double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;
        }

        public double GetLength (double x1, double y1, double x2, double y2)
        {
            return Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2);
        }

        public double GetMaxNumber(double number1, double number2, double number3)
        {
            // TODO Неверное сравнение double чисел
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            // TODO Неверное сравнение double чисел
            else if (number1 < number2 && number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }

        public double GetMinNumber(double number1, double number2, double number3)
        {
            // TODO Неверное сравнение double чисел
            if (number1 < number2 && number1 < number3)
            {
                return number1;
            }
            // TODO Неверное сравнение double чисел
            else if (number1 > number2 && number2 < number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }

        public double GetArea()
        {
            return (0.5 * GetPerimeter());
        }

        public double GetPerimeter()
        {
            return GetLength(x1, y1, x2, y2) + GetLength(x2, y2, x3, y3) + GetLength(x1, y1, x3, y3);
        }
    }
}

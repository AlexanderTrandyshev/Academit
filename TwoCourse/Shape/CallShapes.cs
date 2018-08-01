using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class CallShapes
    {
        public static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(5, 3);
            IShape square = new Square(5);
            IShape triangle = new Triangle(1, 1, 3, 3, 4, 4);

            IShape[] arrayShapes = { circle, rectangle, square, triangle };

            // Массив не отсартирован
            foreach (IShape e in arrayShapes)
            {
                Console.Write($"{e}, ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Массив отсартирован
            Console.WriteLine($"Макс. площадь у фигуры = {GetMaxArrayShape(arrayShapes)}, " +
                $"Площадь = {GetMaxArrayShape(arrayShapes).GetArea()}, " +
                $"Периметер = {GetMaxArrayShape(arrayShapes).GetPerimeter()}, " +
                $"Высота = {GetMaxArrayShape(arrayShapes).Heigth}, " +
                $"Ширина = {GetMaxArrayShape(arrayShapes).Width}" + Environment.NewLine);
        }

        public static IShape GetMaxArrayShape(IShape[] arrayShapes)
        {
            Array.Sort(arrayShapes, new CompSort());

            return arrayShapes[arrayShapes.Length - 1];
        }
    }
}

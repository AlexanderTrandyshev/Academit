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
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 3);
            Square square = new Square(5);
            Triangle triangle = new Triangle(1, 1, 3, 3, 4, 4);

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(square.GetArea());
            Console.WriteLine(triangle.GetArea());

        }
    }
}

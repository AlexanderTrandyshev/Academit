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

            IShape[] array = { circle, rectangle, square, triangle };

            Console.WriteLine(array);

          //  Array.Sort(array, CompSort);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    interface IShape
    {
        double Width
        {
            get;
        }

        double Heigth
        {
            get;
        }

        double GetArea();

        double GetPerimeter();
    }
}

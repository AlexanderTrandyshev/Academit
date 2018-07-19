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
            set;
        }

        double Heigth
        {
            get;
            set;
        }

        double GetArea();

        double GetPerimeter();

    }
}

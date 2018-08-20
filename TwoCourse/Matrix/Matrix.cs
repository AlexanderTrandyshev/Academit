using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace Matrix
{
    class Matrix
    {
        private int n;
        private int m;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;

            double[,] matrix = new double[n,m];
        }


    }
}

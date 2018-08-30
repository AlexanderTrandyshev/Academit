using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace ProjectMatrix
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

            for(int i = 0; i < matrix.Length; ++i)
            {
                for (int k = 0; k < matrix.Length; ++k)
                {
                    matrix[i, k] = 0;
                }
            }
        }

        public Matrix(Matrix matrix)
        {
        }

        public int GetSizeMatrix(Matrix matrix)
        {
        }
    }
}

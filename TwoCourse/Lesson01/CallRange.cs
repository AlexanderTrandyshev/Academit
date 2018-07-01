using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson01
{
    class CallRange
    {
        public static void Main(string[] args)
        {
            Range range = new Range(1, 7);
            Console.WriteLine("Длинна отрезка = {0}", range.GetLength());
            Console.WriteLine("Точка лежит на отрезке: {0}", range.IsInside(5));
        }
    }
}

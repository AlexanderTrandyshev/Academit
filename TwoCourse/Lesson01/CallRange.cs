using System;
using System.Collections.Generic;
using System.Text;

namespace Range
{
    class CallRange
    {
        public static void Main(string[] args)
        {
            Range range1 = new Range(1, 7);
            Range range2 = new Range(3, 10);
            Console.WriteLine("Длинна отрезка = {0}", range1.GetLengthInterval);
            Console.WriteLine("Точка лежит на отрезке: {0}", range1.IsInside(5));
            range1.From = 5;
            Console.WriteLine("Пересечение интервалов ");
        }
    }
}

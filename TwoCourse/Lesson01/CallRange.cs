using System;
using System.Collections.Generic;
using System.Text;

namespace Range
{
    class CallRange
    {
        public static void Main(string[] args)
        {
            Range range1 = new Range(1, 10);
            Range range2 = new Range(5, 10);
            Range range3 = new Range(1, 10);
            Range range4 = new Range(0, 11);
            Range range5 = new Range(0, 5);
            Range range6 = new Range(2, 6);
            Range range7 = new Range(2, 13);
            Range range8 = new Range(1, 5);
            Range range9 = new Range(2, -5);
            Range range10 = new Range(11, 2);
            Range range11 = new Range(11, -1); 
            Range range12 = new Range(11, 12); 

            Console.WriteLine($"Длинна отрезка = {range1.GetLengthInterval}");
            Console.WriteLine($"Точка лежит на отрезке: {range1.IsInside(5)}");

            Console.WriteLine($"Пересечение интервалов 1 и 2 = (5, 10) : {range1.GetIntersectionIntervals(range2)}");
            Console.WriteLine($"Пересечение интервалов 1 и 3 = (1, 10) : {range1.GetIntersectionIntervals(range3)}");
            Console.WriteLine($"Пересечение интервалов 1 и 4 = (1, 10) : {range1.GetIntersectionIntervals(range4)}");
            Console.WriteLine($"Пересечение интервалов 1 и 5 = (1, 5) : {range1.GetIntersectionIntervals(range5)}");
            Console.WriteLine($"Пересечение интервалов 1 и 6 = (2, 6) : {range1.GetIntersectionIntervals(range6)}");
            Console.WriteLine($"Пересечение интервалов 1 и 7 = (2, 10) : {range1.GetIntersectionIntervals(range7)}");
            Console.WriteLine($"Пересечение интервалов 1 и 8 = (1, 5) : {range1.GetIntersectionIntervals(range8)}");
            Console.WriteLine($"Пересечение интервалов 1 и 9 = (1, 2) : {range1.GetIntersectionIntervals(range9)}");
            Console.WriteLine($"Пересечение интервалов 1 и 10 = (2, 10) : {range1.GetIntersectionIntervals(range10)}");
            Console.WriteLine($"Пересечение интервалов 1 и 11 = (1, 10) : {range1.GetIntersectionIntervals(range11)}");
            Console.WriteLine($"Пересечение интервалов 1 и 12 = (null) : {range1.GetIntersectionIntervals(range12)}");

            /*
             * пересечение - не статические методы
             объединение - массив объектов
             
             */
        }
    }
}

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

            Range range2 = new Range(0, 5);
            Range range3 = new Range(5, 15);
            Range range4 = new Range(2, 9);
            Range range5 = new Range(11, 12);
            Range range6 = new Range(7, -2);
            Range range7 = new Range(12, 5);

            Console.WriteLine($"Длинна отрезка = {range1.GetLengthInterval}");
            Console.WriteLine($"Точка лежит на отрезке: {range1.IsInside(5)}" + Environment.NewLine);

            Console.WriteLine($"Пересечение интервалов 1 и 2 = (1, 5) : {range1.GetIntersectionIntervals(range2)}");
            Console.WriteLine($"Пересечение интервалов 1 и 3 = (5, 10) : {range1.GetIntersectionIntervals(range3)}");
            Console.WriteLine($"Пересечение интервалов 1 и 4 = (2, 9) : {range1.GetIntersectionIntervals(range4)}");
            Console.WriteLine("Пересечение интервалов 1 и 5 = (null) : {0}", range1.GetIntersectionIntervals(range5).ToString());
            Console.WriteLine($"Пересечение интервалов 1 и 6 = (1, 7) : {range1.GetIntersectionIntervals(range6)}");
            Console.WriteLine($"Пересечение интервалов 1 и 7 = (5, 10) : {range1.GetIntersectionIntervals(range7)}" + Environment.NewLine);

            Range range13 = new Range(10, 12);
            Range range14 = new Range(11, 13);
            Console.WriteLine($"Объединение интервалов 1 и 13 = (1, 12) : {range1.GetJoinIntervals(range13).ToString()}");
            Console.WriteLine($"Объединение интервалов 1 и 13 = (1, 12) : {range1.GetJoinIntervals(range14)}");


            /*
             * пересечение - не статические методы
             объединение - массив объектов
             
             */
        }
    }
}

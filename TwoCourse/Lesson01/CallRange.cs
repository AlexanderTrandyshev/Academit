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

            Console.WriteLine($"Длинна отрезка = {range1.GetLengthInterval}");
            Console.WriteLine($"Точка лежит на отрезке: {range1.IsInside(5)}");
            // Как получить от "GetIntersectionIntervals" целое значение?
            Console.WriteLine($"Пересечение интервалов: {range1.GetIntersectionIntervals(range2)}");

            /*GetIntersectionIntervals
             *Сделать не через структуру? - null не передает (не ref)
             * Сделать через объект? - как можно обратиться к полям передоваемого класса? (присвоить полям и вернуть?(-_-))
             * Сделать через кортежи? - null не передает (не ref)
             * Сделать через массив? - не печатает сами точки а объект. (можно создавать ф-ию для печати? или сделать стринг(не хочется ведь это точки)?)
            
            
            пересечение - не статические методы
             объединение - массив объектов
             
             */
        }
    }
}

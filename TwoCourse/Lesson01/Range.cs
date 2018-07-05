using System;

namespace Range
{
    class Range
    {

        public double From
        {
            get;
            set;
        }

        public double To
        {
            get;
            set;
        }

        public double GetLengthInterval
        {
            get { return To - From; }
        }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double[] GetIntersectionIntervals(double start, double end)
        {
            //Условие, что интервалы пересекаются
            if (From <= end && To >= start)
            {
                double[] newInterval = new double[(int)Math.Round(GetLengthInterval)];
                double[] startEndNewInterval = new double[2];

                for (int i = 0, j = 0; i <= To; ++i)
                {
                    // условие, что i пренадлежит интервалу №2
                    // TODO не правильно сравнивает вещественное число!?
                    if (i >= start && i <= end)
                    {
                /* Сейчас массив может быть не полностью заполнен или переполнен и нужно изменять его размерность*/
                        newInterval[j] = i;
                        ++j;

                        // TODO написать код для расширения массива newInterval
                    }

                }
                // TODO написать код для размера массива newInterval сужения в случае его полного заполнения
                // беруться 1 и последний элемент массива (учесть что это не одна и таже точка)
                startEndNewInterval[0] = newInterval[0]; 
                startEndNewInterval[1] = newInterval[newInterval.Length - 1];
                
                // массив передается с двумя значениями или одним (если пересечение в одной точке)
                return startEndNewInterval;
            }
            else
            {
                return null;
            }
        }

        public bool IsInside(double point)
        {
            return point >= From && point <= To;
        }
    }
}

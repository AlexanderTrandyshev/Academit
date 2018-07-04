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

                for (int i = 0, j = 0; i <= To; ++i)
                {
                    // условие, что i пренадлежит интервалу №2
                    if (i >= start && i <= end)
                    {
                        newInterval[j] = i;
                        ++j;
                    }
                }
                // найти способ возврата массива с двумя значениями
                // newInterval = { start; };

                return newInterval;
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

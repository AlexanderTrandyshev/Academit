using System;

namespace Lesson01
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

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLengthInterval1()
        {
            return To - From;
        }

        public double[] GetIntersectionIntervals(double from1, double to1, double from2, double to2)
        {
            //Условие, что интервалы пересекаются
            if (from1 <= to2 && to1 >= from2)
            {
                double[] newInterval = new double[(int)Math.Round(GetLengthInterval1())];

                for (int i = 0, j = 0; i <= to1; ++i)
                {
                    // условие, что i пренадлежит интервалу №2
                    if (i >= from2 && i <= to2)
                    {
                        newInterval[j] = i;
                        ++j;
                    }
                }

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

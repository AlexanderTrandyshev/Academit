using System;
//спросить про правильное написание
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

        public static double NewFrom
        {
            get;
            set;
        }

        public static double NewTo
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

        // Пересечения 
        /*
        public Interval GetIntersectionIntervals(double start, double end)
        {
            // if(From <= end && To >= end)   !(A1 > B2 || A2 < B1) - условие пересечения?

            double[] newInterval = new double[5];
            double i = From;
            int j = 0;
            double e = 1e11;

            while (i < To || Math.Abs(To - i) == e)
            {
                if ((i > start && i < end) || Math.Abs(i - end) == 0 || Math.Abs(i - start) == 0)
                {
                    newInterval[j] = i;

                    if (j >= newInterval.Length - 1)
                    {
                        double[] oldnewInterval = newInterval;
                        newInterval = new double[oldnewInterval.Length * 2];

                        oldnewInterval.CopyTo(newInterval, 0);
                    }

                    ++j;
                }

                ++i;
            }

            if (j == 0)
            {
                // как в struct передать null? 
                return new Interval(null);
            }
            // TODO беруться 1 и последний элемент массива (учесть что это не одна и таже точка ?)
            double[] usedNewInterval = new double[j];

            for (int k = 0; k < j; ++k)
            {
                usedNewInterval[k] = newInterval[k];
            }

            double[] arrayTop = { usedNewInterval[0], usedNewInterval[usedNewInterval.Length - 1] };
            return new Interval(usedNewInterval[0], usedNewInterval[usedNewInterval.Length - 1]);
        }
        */

        // попытка через Object

        public Object GetIntersectionIntervals(Range interval)
        {
            // if(From <= end && To >= end)   !(A1 > B2 || A2 < B1) - условие пересечения?
            double[] newInterval = new double[5];
            double i = From;
            int j = 0;
            //double e = 1e-11;

            while (i <= To)
            {
                if (i >= interval.From && i <= interval.To)
                {
                    newInterval[j] = i;

                    if (j >= newInterval.Length - 1)
                    {
                        double[] oldnewInterval = newInterval;
                        newInterval = new double[oldnewInterval.Length * 2];

                        oldnewInterval.CopyTo(newInterval, 0);
                    }

                    ++j;
                }

                ++i;
            }

            if (j == 0)
            {
                return null;
            }

            double[] usedNewInterval = new double[j];

            for (int k = 0; k < j; ++k)
            {
                usedNewInterval[k] = newInterval[k];
            }

            return new Range(NewFrom = usedNewInterval[0], NewTo = usedNewInterval[usedNewInterval.Length - 1]);
        }

        // Объединение
        /*
         * public double[] GetJoinIntervals(double start, double end)
        {

        }
        */

        public bool IsInside(double point)
        {
            return point >= From && point <= To;
        }



        public override string ToString()
        {
            return $"{NewFrom}, {NewTo}";
        }

        public struct Interval
        {
            public readonly double start;
            public readonly double end;

            public Interval(double _start, double _end)
            {
                start = _start;
                end = _end;
            }
        }
    }
}

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
        public Object GetIntersectionIntervals(Range interval)
        {
            double newFrom;
            double newTo;
            double e = 1e-11;
            // от From до interval.To
            if ((Math.Abs(From - interval.From) < e || (From > interval.From) && To > interval.To))
            {
                newFrom = From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            // от From до To
            else if ((From > interval.From && To < interval.To) || (From < interval.From && To > interval.To))
            {
                return new Range(From, To);
            }
            // от From до interval.From
            else if (From > interval.To && From < interval.From && To > interval.To && To > interval.From)
            {
                newFrom = From;
                newTo = interval.From;
                return new Range(newFrom, newTo);
            } 
            // от interval.From до To
            else if (From < interval.From && (To < interval.To || Math.Abs(interval.To - To) < e))
            {
                newFrom = interval.From;
                newTo = To;
                return new Range(newFrom, newTo);
            } 
            // от interval.From до interval.To
            else if ((From < interval.From && To > interval.To) || (Math.Abs (From - interval.From) < e && Math.Abs(To - interval.To) < e))
            {
                newFrom = interval.From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            else
            {
                return null;
            }
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
        // точно не так должно быть!
        public override string ToString()
        {
            return $"({From}, {To})";
        }
    }
}

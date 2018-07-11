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
        public object GetIntersectionIntervals(Range interval)
        {
            double newFrom;
            double newTo;
            double e = 1e-11;
            // если числа положительные
            if (From < interval.To && To > interval.From)
            {
                // от From до interval.To
                if (From < interval.To && To > interval.To && (From > interval.From || Math.Abs(From - interval.From) < e))
                {
                    newFrom = From;
                    newTo = interval.To;
                    return new Range(newFrom, newTo);
                }
                // от From до To
                else if ((Math.Abs(From - interval.From) < e && Math.Abs(To - interval.To) < e) || (From > interval.From && To < interval.To))
                {
                    return new Range(From, To);
                }
                // от interval.From до To
                else if ((From < interval.From || Math.Abs(From - interval.From) < e) && (To < interval.To || Math.Abs(To - interval.To) < e))
                {
                    newFrom = interval.From;
                    newTo = To;
                    return new Range(newFrom, newTo);
                }
                // от interval.From до interval.To
                else
                {
                    newFrom = interval.From;
                    newTo = interval.To;
                    return new Range(newFrom, newTo);
                }
            }
            // если interval.To - отрицательное
            else if ((From > interval.To || Math.Abs(From - interval.To) < e))
            {
                if (To > interval.From)
                {
                    newFrom = From;
                    newTo = interval.From;
                    return new Range(newFrom, newTo);
                }
                else
                {
                    newFrom = From;
                    newTo = To;
                    return new Range(newFrom, newTo);
                }
            }
            else if (From < interval.From && To > interval.To)
            {
                newFrom = interval.To;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else
            {
                return null;
            }
        }

        // Объединение
         public object GetJoinIntervals(Range interval)
         {
            double newFrom;
            double newTo;
            double e = 1e-11;
            
            if(From < interval.From && To > interval.From && (To < interval.To || Math.Abs(To - interval.To) < e))
            {
                newFrom = From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            else if ((From < interval.From || Math.Abs(From - interval.From) < e) && To > interval.From && (To > interval.To || Math.Abs(To - interval.To) < e))
            {
                newFrom = From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else if (From > interval.From && To > interval.From && To < interval.To)
            {
                newFrom = interval.From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            else if (From > interval.From && To > interval.To)
            {
                newFrom = interval.From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
         }
        

        public bool IsInside(double point)
        {
            return point >= From && point <= To;
        }
        // TODO точно не так должно быть! (попробовать перегрузку)
        public override string ToString()
        {
            if ()
            {
                return $"({From}, {To})";

            }
            else
            {
                return null;
            }
        }
    }
}

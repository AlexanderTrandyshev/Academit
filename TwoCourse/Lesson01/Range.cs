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

            // (+)
            if (From > interval.From && From < interval.To && To > interval.To)
            {
                newFrom = From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            else if (From < interval.From && To > interval.From && To < interval.To)
            {
                newFrom = interval.From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            // (-)
            else if (From < interval.From && From > interval.To && To > interval.From)
            {
                newFrom = From;
                newTo = interval.From;
                return new Range(newFrom, newTo);
            }
            else if (From < interval.From && From < interval.To && To > interval.To && To < interval.From)
            {
                newFrom = interval.To;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            // внутри from и to или внутри interval.From и interval.To
            else if (From < interval.From && To > interval.To)
            {
                newFrom = interval.From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            else if (From > interval.From && To < interval.To)
            {
                newFrom = From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            // Нет пересечения
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

            // (+)
            if (From > interval.From && From < interval.To && To > interval.To)
            {
                newFrom = interval.From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else if (From < interval.From && To > interval.From && To < interval.To)
            {
                newFrom = From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            // (-)
            else if (From > interval.To && From < interval.From && To > interval.From)
            {
                newFrom = interval.To;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else if (From < interval.To && To > interval.To && To < interval.From)
            {
                newFrom = From;
                newTo = interval.From;
                return new Range(newFrom, newTo);
            }
            // внутри from и to или внутри interval.From и interval.To
            else if (From < interval.From && To > interval.To)
            {
                newFrom = From;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else if (From > interval.From && To < interval.To)
            {
                newFrom = interval.From;
                newTo = interval.To;
                return new Range(newFrom, newTo);
            }
            // Нет пересечения
            else
            {
                Range[] arrayIntervals = { new Range(From, To), new Range(interval.From, interval.To) };
                return arrayIntervals;
            }
         }

        // Разница
        public object GetDifferenceIntervals(Range interval)
        {
            double newFrom;
            double newTo;

            // TODO что делать если одно множество внутри другого?
            if (From > interval.From && From < interval.To && To > interval.To)
            {
                newFrom = interval.To;
                newTo = To;
                return new Range(newFrom, newTo);
            }
            else if ( From < interval.From && To > interval.From && To < interval.To)
            {
                newFrom = From;
                newTo = interval.From;
                return new Range(newFrom, newTo);
            }
            else
            {
                Range[] arrayIntervals = { new Range(From, To), new Range(interval.From, interval.To) };
                return arrayIntervals;
            }
        }

        public bool IsInside(double point)
        {
            return point >= From && point <= To;
        }

        // TODO (можно писать код только в теле метода)
        public override string ToString()
        {
            return $"({From}, {To})";
        }
    }
}

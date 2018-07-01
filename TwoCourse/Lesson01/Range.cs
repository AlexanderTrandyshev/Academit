﻿using System;

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

        public Range (double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength ()
        {
            return To - From;
        }

        public bool IsInside (double point)
        {
            return point >= From && point <= To;
        }
    }
}
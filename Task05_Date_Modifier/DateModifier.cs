using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int CalculateDiff(string stringFirstData, string stringSecondDate)
        {
            DateTime firstDate = DateTime.Parse(stringFirstData);
            DateTime secondDate = DateTime.Parse(stringSecondDate);

            TimeSpan diff = secondDate - firstDate;
            return Math.Abs(diff.Days);

        }

    }
}

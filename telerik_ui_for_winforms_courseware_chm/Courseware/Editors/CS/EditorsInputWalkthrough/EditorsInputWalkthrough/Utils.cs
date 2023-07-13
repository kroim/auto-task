using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EditorsInputWalkthrough
{
    public class Utils
    {
        #region Date and Time

        // Return a business day based on a start date and number
        // of days to add. This should always return a weekday date.
        public static DateTime AddBusinessDays(DateTime startDate, int daysToAdd)
        {
            DateTime result = startDate;
            int i = 0;
            double temp = 0;

            // cycle until the requested number of days to add is
            // reached. Pass over any weekend days.
            while (i < daysToAdd)
            {
                temp++;
                result = startDate.AddDays(temp);

                if (IsWeekend(result))
                    continue;

                i++;
            }
            return result;
        }

        // returns true if the date passed in is a Saturday or Sunday
        public static bool IsWeekend(DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday);
        }

        #endregion

        #region Color

        public static Color GetContrastingColor(Color color)
        {
            return Color.FromArgb(color.ToArgb() ^ 0x00ffffff);
        }

        public static string GetKnownColorName(Color color)
        {

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                if (color.ToArgb() == Color.FromKnownColor(knownColor).ToArgb())
                {
                    return Color.FromKnownColor(knownColor).Name;
                }
            }
            return String.Empty;
        }

        #endregion
    }
}

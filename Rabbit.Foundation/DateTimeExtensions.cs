using System;

namespace Rabbit.Foundation
{
    public static class DateTimeExtensions
    {
        public static DateTime LastDateOfSameMonth(this DateTime currentDate)
        {
            return GetLastDateOfMonth(currentDate.Year, currentDate.Month);
        }

        public static DateTime LastDateOfNMonths(this DateTime currentDate, int newMonths)
        {
            return GetLastDateOfMonth(currentDate.Year, currentDate.Month + newMonths);
        }

        public static DateTime GetLastDateOfMonth(int year, int month)
        {
            return new DateTime(year, month + 1, 1).AddDays(-1);
        }
    }
}

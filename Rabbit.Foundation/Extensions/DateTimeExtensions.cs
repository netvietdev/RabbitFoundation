using System;

namespace Rabbit.Foundation.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetLastDateOfMonth(this DateTime currentDate)
        {
            return GetLastDateOfMonth(currentDate.Year, currentDate.Month);
        }

        public static DateTime GetLastDateOfMonth(this DateTime currentDate, int nextMonths)
        {
            return GetLastDateOfMonth(currentDate.Year, currentDate.Month + nextMonths);
        }

        public static DateTime GetLastDateOfMonth(int year, int month)
        {
            while (month >= 12)
            {
                year += 1;
                month -= 12;
            }

            return new DateTime(year, month + 1, 1).AddDays(-1);
        }
    }
}

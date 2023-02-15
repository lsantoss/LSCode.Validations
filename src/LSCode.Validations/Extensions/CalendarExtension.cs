using System;

namespace LSCode.Validations.Extensions
{
    public static class CalendarExtension
    {
        /// <summary>Validates whether the date is a weekday.</summary>
        /// <param name="date">Date to be validated.</param>
        /// <returns>True if it's a weekday. False if it's not.</returns>
        public static bool IsWeekday(this DateTime date) => date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>Validates if the date is a weekend.</summary>
        /// <param name="date">Date to be validated.</param>
        /// <returns>True if it's a weekend. False if it's not.</returns>
        public static bool IsWeekend(this DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}
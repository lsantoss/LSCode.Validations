using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain days of the week validations with boolean returns.</summary>
    public static class WeekDaysExtension
    {
        /// <summary>Validates if the date is a Friday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Friday. False if not.</returns>
        public static bool IsFriday(this DateTime value) => value.DayOfWeek == DayOfWeek.Friday;

        /// <summary>Validates if the date is a Monday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Monday. False if not.</returns>
        public static bool IsMonday(this DateTime value) => value.DayOfWeek == DayOfWeek.Monday;

        /// <summary>Validates if the date is not a Friday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Friday. False if is.</returns>
        public static bool IsNotFriday(this DateTime value) => value.DayOfWeek != DayOfWeek.Friday;

        /// <summary>Validates if the date is not a Monday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Monday. False if is.</returns>
        public static bool IsNotMonday(this DateTime value) => value.DayOfWeek != DayOfWeek.Monday;

        /// <summary>Validates if the date is not a Saturday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Saturday. False if is.</returns>
        public static bool IsNotSaturday(this DateTime value) => value.DayOfWeek != DayOfWeek.Saturday;

        /// <summary>Validates if the date is not a Sunday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Sunday. False if is.</returns>
        public static bool IsNotSunday(this DateTime value) => value.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>Validates if the date is not a Thursday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Thursday. False if is.</returns>
        public static bool IsNotThursday(this DateTime value) => value.DayOfWeek != DayOfWeek.Thursday;

        /// <summary>Validates if the date is not a Tuesday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Tuesday. False if is.</returns>
        public static bool IsNotTuesday(this DateTime value) => value.DayOfWeek != DayOfWeek.Tuesday;

        /// <summary>Validates if the date is not a Wednesday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a Wednesday. False if is.</returns>
        public static bool IsNotWednesday(this DateTime value) => value.DayOfWeek != DayOfWeek.Wednesday;

        /// <summary>Validates whether the date is not a weekday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a weekday. False if is.</returns>
        public static bool IsNotWeekday(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>Validates if the date is a not weekend.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a weekend. False if is.</returns>
        public static bool IsNotWeekend(this DateTime value) => value.DayOfWeek != DayOfWeek.Saturday && value.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>Validates if the date is a Saturday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Saturday. False if not.</returns>
        public static bool IsSaturday(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday;

        /// <summary>Validates if the date is a Sunday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Sunday. False if not.</returns>
        public static bool IsSunday(this DateTime value) => value.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>Validates if the date is a Thursday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Thursday. False if not.</returns>
        public static bool IsThursday(this DateTime value) => value.DayOfWeek == DayOfWeek.Thursday;

        /// <summary>Validates if the date is a Tuesday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Tuesday. False if not.</returns>
        public static bool IsTuesday(this DateTime value) => value.DayOfWeek == DayOfWeek.Tuesday;

        /// <summary>Validates if the date is a Wednesday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a Wednesday. False if not.</returns>
        public static bool IsWednesday(this DateTime value) => value.DayOfWeek == DayOfWeek.Wednesday;

        /// <summary>Validates whether the date is a weekday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a weekday. False if not.</returns>
        public static bool IsWeekday(this DateTime value) => value.DayOfWeek != DayOfWeek.Saturday && value.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>Validates if the date is a weekend.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if a weekend. False if not.</returns>
        public static bool IsWeekend(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
    }
}
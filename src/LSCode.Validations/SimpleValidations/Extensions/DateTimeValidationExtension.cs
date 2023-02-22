using System;

namespace LSCode.Validations.SimpleValidations.Extensions
{
    public static class DateTimeValidationExtension
    {
        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool AreEquals(this DateTime value, DateTime comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool AreNotEquals(this DateTime value, DateTime comparedValue) => value != comparedValue;

        /// <summary>Validates if the value is greater or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
        /// <returns>True if greater or equal. False if not.</returns>
        public static bool IsGreaterOrEqualsThan(this DateTime value, DateTime comparedValue) => value >= comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this DateTime value, DateTime comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this DateTime value, DateTime comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this DateTime value, DateTime comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is equal to the maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if equal to the maximum value. False if not.</returns>
        public static bool IsMaxValue(this DateTime value) => value == DateTime.MaxValue;

        /// <summary>Validates if the value is equal to the minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if equal to the minimum value. False if not.</returns>
        public static bool IsMinValue(this DateTime value) => value == DateTime.MinValue;

        /// <summary>Validates if the value is not equal to the maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not equal to the maximum value. False if is.</returns>
        public static bool IsNotMaxValue(this DateTime value) => value != DateTime.MaxValue;

        /// <summary>Validates if the value is not equal to the minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not equal to the minimum value. False if is.</returns>
        public static bool IsNotMinValue(this DateTime value) => value != DateTime.MinValue;

        /// <summary>Validates whether the date is not a weekday.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a weekday. False if is.</returns>
        public static bool IsNotWeekday(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>Validates if the date is a not weekend.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if not a weekend. False if is.</returns>
        public static bool IsNotWeekend(this DateTime value) => value.DayOfWeek != DayOfWeek.Saturday && value.DayOfWeek != DayOfWeek.Sunday;

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
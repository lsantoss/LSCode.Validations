using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value contains the minimum value of the type with boolean returns.</summary>
    public static class IsMinValueValidationExtension
    {
        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this sbyte value) => value == sbyte.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this byte value) => value == byte.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this short value) => value == short.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this ushort value) => value == ushort.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this int value) => value == int.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this uint value) => value == uint.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this long value) => value == long.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this ulong value) => value == ulong.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this float value) => value == float.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this double value) => value == double.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this decimal value) => value == decimal.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this char value) => value == char.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this DateTime value) => value == DateTime.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this TimeSpan value) => value == TimeSpan.MinValue;
    }
}
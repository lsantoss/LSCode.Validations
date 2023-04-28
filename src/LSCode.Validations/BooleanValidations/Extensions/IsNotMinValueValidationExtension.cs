using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value not contains the minimum value of the type with boolean returns.</summary>
    public static class IsNotMinValueValidationExtension
    {
        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this sbyte value) => value != sbyte.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this byte value) => value != byte.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this short value) => value != short.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this ushort value) => value != ushort.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this int value) => value != int.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this uint value) => value != uint.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this long value) => value != long.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this ulong value) => value != ulong.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this float value) => value != float.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this double value) => value != double.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this decimal value) => value != decimal.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this char value) => value != char.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this DateTime value) => value != DateTime.MinValue;

        /// <summary>Validates if it has no minimum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this TimeSpan value) => value != TimeSpan.MinValue;
    }
}
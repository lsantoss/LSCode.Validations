using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value not contains the maximum value of the type with boolean returns.</summary>
    public static class IsNotMaxValueExtension
    {
        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this sbyte value) => value != sbyte.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this byte value) => value != byte.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this short value) => value != short.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this ushort value) => value != ushort.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this int value) => value != int.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this uint value) => value != uint.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this long value) => value != long.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this ulong value) => value != ulong.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this float value) => value != float.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this double value) => value != double.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this decimal value) => value != decimal.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this char value) => value != char.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this DateTime value) => value != DateTime.MaxValue;

        /// <summary>Validates if it has a maximum value.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this TimeSpan value) => value != TimeSpan.MaxValue;
    }
}
using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsMinValueExtension
    {
        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this sbyte value) => value == sbyte.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this byte value) => value == byte.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this short value) => value == short.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this ushort value) => value == ushort.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this int value) => value == int.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this uint value) => value == uint.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this long value) => value == long.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this ulong value) => value == ulong.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this float value) => value == float.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this double value) => value == double.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this decimal value) => value == decimal.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this char value) => value == char.MinValue;

        /// <summary>Validates if it has minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a minimum value. False if not.</returns>
        public static bool IsMinValue(this DateTime value) => value == DateTime.MinValue;
    }
}
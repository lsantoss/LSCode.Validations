using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsMaxValueExtension
    {
        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this sbyte value) => value == sbyte.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this byte value) => value == byte.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this short value) => value == short.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this ushort value) => value == ushort.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this int value) => value == int.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this uint value) => value == uint.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this long value) => value == long.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this ulong value) => value == ulong.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this float value) => value == float.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this double value) => value == double.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this decimal value) => value == decimal.MaxValue;

        /// <summary>Validates if it has maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has a maximum value. False if not.</returns>
        public static bool IsMaxValue(this DateTime value) => value == DateTime.MaxValue;
    }
}
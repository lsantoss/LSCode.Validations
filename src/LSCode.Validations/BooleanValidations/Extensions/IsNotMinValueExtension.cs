using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNotMinValueExtension
    {
        /// <summary>validates if it has no minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this sbyte value) => value != sbyte.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this byte value) => value != byte.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this short value) => value != short.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this ushort value) => value != ushort.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this int value) => value != int.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this uint value) => value != uint.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this long value) => value != long.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this ulong value) => value != ulong.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this float value) => value != float.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this double value) => value != double.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this decimal value) => value != decimal.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this char value) => value != char.MinValue;

        /// <summary>validates if it has a minimum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no minimum value. False if it has a minimum value.</returns>
        public static bool IsNotMinValue(this DateTime value) => value != DateTime.MinValue;
    }
}
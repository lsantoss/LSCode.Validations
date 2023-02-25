using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNotMaxValueExtension
    {
        /// <summary>validates if it has no maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this sbyte value) => value != sbyte.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this byte value) => value != byte.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this short value) => value != short.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this ushort value) => value != ushort.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this int value) => value != int.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this uint value) => value != uint.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this long value) => value != long.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this ulong value) => value != ulong.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this float value) => value != float.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this double value) => value != double.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this decimal value) => value != decimal.MaxValue;

        /// <summary>validates if it has a maximum value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if it has no maximum value. False if it has a maximum value.</returns>
        public static bool IsNotMaxValue(this DateTime value) => value != DateTime.MaxValue;
    }
}
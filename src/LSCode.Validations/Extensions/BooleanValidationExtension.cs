using System;
using System.Text.RegularExpressions;

namespace LSCode.Validations.Extensions
{
    /// <summary>Provides extension methods that contain validations in general with boolean returns.</summary>
    public static class BooleanValidationExtension
    {
        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this sbyte value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this byte value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this short value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ushort value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this int value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this uint value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this long value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, sbyte comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, short comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, int comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, long comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this ulong value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this float value, decimal comparedValue) => (decimal)value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, float comparedValue) => (float)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this double value, decimal comparedValue) => (decimal)value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, float comparedValue) => (float)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, double comparedValue) => (double)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this decimal value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        public static bool IsGreaterOrEqual(this DateTime value, DateTime comparedValue) => value >= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this sbyte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this byte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this short value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ushort value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this int value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this uint value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this long value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, short comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, int comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, long comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this ulong value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this float value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this double value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, double comparedValue) => (double)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this decimal value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmaller(this DateTime value, DateTime comparedValue) => value <= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this sbyte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this byte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this short value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(this ushort value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ushort value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this int value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(this uint value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this uint value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this long value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, short comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, int comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(this ulong value, long comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this ulong value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this float value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(this double value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, float comparedValue) => (float)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this double value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, float comparedValue) => (float)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, double comparedValue) => (double)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this decimal value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        public static bool IsSmallerOrEqual(this DateTime value, DateTime comparedValue) => value <= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if false or False if true.</returns>
        public static bool IsFalse(this bool value) => value == false;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if true or False if false.</returns>
        public static bool IsTrue(this bool value) => value == true;

        //========================================================================================================================================  


        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or False if not.</returns>
        public static bool IsNull(this object value) => value == null;

        /// <summary>Validates if value is or empty.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or empty. False if not.</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        /// <summary>Validates if value is or empty or white spaces.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null, empty or white spaces. False if not.</returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>Validates if the value contains a text snippet.</summary>
        /// <param name="value">Main text.</param>
        /// <param name="text">Text that will be checked if it is contained in the main text.</param>
        /// <returns>True if the value contains a snippet of text or False if it does not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool Contains(this string value, string text) => value != null && text != null && value.Contains(text);

        /// <summary>Validates if the text length is equal to the expected length.</summary>
        /// <param name="value">Text.</param>
        /// <param name="length">Expected text length.</param>
        /// <returns>True if the text length is the same or False if it is different.</returns>
        public static bool HasEqualLength(this string value, int length) => value != null && value.Length == length;

        /// <summary>Validates if the text length is different from the expected length.</summary>
        /// <param name="value">Text.</param>
        /// <param name="length">Unexpected text length.</param>
        /// <returns>True if the text length is different or False if it is the same.</returns>
        public static bool HasDifferentLength(this string value, int length) => value != null && value.Length != length;

        /// <summary>Validates if the maximum text length has been reached.</summary>
        /// <param name="value">Text.</param>
        /// <param name="maximumLenght">Maximum expected length for text.</param>
        /// <returns>True if the maximum text length has been reached or False if it has been reached.</returns>
        public static bool HasMaximumLength(this string value, int maximumLenght) => value != null && value.Length <= maximumLenght;

        /// <summary>Validates if the minimum text length has been reached.</summary>
        /// <param name="value">Text.</param>
        /// <param name="minimumLength">Minimum expected text length.</param>
        /// <returns>True if the minimum text length has been reached or False if not.</returns>
        public static bool HasMinimumLength(this string value, int minimumLength) => value != null && value.Length >= minimumLength;

        /// <summary>Validates if the url is valid.</summary>
        /// <param name="value">URL that will be validated.</param>
        /// <returns>True if it's a url or False if it's not.</returns>
        public static bool IsUrl(this string value) => Uri.IsWellFormedUriString(value, UriKind.Absolute);

        /// <summary>Validates if the email is valid.</summary>
        /// <param name="email">Email that will be validated.</param>
        /// <returns>True if it's an email or False if it's not.</returns>
        public static bool IsEmail(this string email) => email != null && Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        /// <summary>Validate the mobile number.</summary>
        /// <param name="value">Cellphone number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsCellphone(this string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        /// <summary>Validates the phone number.</summary>
        /// <param name="value">Telephone number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsTelephone(this string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        /// <summary>Validates the CEP number.</summary>
        /// <param name="value">CEP.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsCEP(this string value) => value != null && Regex.IsMatch(value, @"^\d{5}\-?\d{3}$");

        /// <summary>Validates the CNPJ number.</summary>
        /// <param name="value">CNPJ number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsCNPJ(this string value)
        {
            var mt1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var mt2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum; int rest; string digit; string tempCNPJ;

            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");

            if (value.Length != 14)
                return false;

            if (value == "00000000000000" || value == "11111111111111" ||
                value == "22222222222222" || value == "33333333333333" ||
                value == "44444444444444" || value == "55555555555555" ||
                value == "66666666666666" || value == "77777777777777" ||
                value == "88888888888888" || value == "99999999999999")
                return false;

            tempCNPJ = value.Substring(0, 12);
            sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt1[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = rest.ToString();

            tempCNPJ += digit;
            sum = 0;
            for (int i = 0; i < 13; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt2[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit += rest.ToString();

            return value.EndsWith(digit);
        }

        /// <summary>Validates the CPF number.</summary>
        /// <param name="value">CPF number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsCPF(this string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");

            if (value == null)
                return false;

            var posicao = 0;
            var totalDigito1 = 0;
            var totalDigito2 = 0;
            var dv1 = 0;
            var dv2 = 0;

            var digitosIdenticos = true;
            var ultimoDigito = -1;

            foreach (var c in value)
            {
                if (char.IsDigit(c))
                {
                    var digito = c - '0';
                    if (posicao != 0 && ultimoDigito != digito)
                        digitosIdenticos = false;

                    ultimoDigito = digito;
                    if (posicao < 9)
                    {
                        totalDigito1 += digito * (10 - posicao);
                        totalDigito2 += digito * (11 - posicao);
                    }
                    else if (posicao == 9)
                        dv1 = digito;
                    else if (posicao == 10)
                        dv2 = digito;

                    posicao++;
                }
            }

            if (posicao > 11)
                return false;

            if (digitosIdenticos)
                return false;

            var digito1 = totalDigito1 % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            if (dv1 != digito1)
                return false;

            totalDigito2 += digito1 * 2;
            var digito2 = totalDigito2 % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            return dv2 == digito2;
        }

        /// <summary>Validates if the text has at least one letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool ContainsLetter(this string value) => Regex.IsMatch(value, @"[a-z]+|[A-Z]+");

        /// <summary>Validates if the text has at least one capital letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool ContainsCapitalLetter(this string value) => Regex.IsMatch(value, @"[A-Z]+");

        /// <summary>Validates if the text has at least one lowercase letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool ContainsLowercaseLetter(this string value) => Regex.IsMatch(value, @"[a-z]+");

        /// <summary>Validates if the text has at least one number.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool ContainsNumber(this string value) => Regex.IsMatch(value, @"[0-9]+");

        /// <summary>Validates if the text has at least one special character.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool ContainsSpecialCharacter(this string value) => Regex.IsMatch(value, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

        /// <summary>Validates if the text is composed only of numbers.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        public static bool IsOnlyNumbers(this string value) => Regex.IsMatch(value, @"^[0-9]+$");
    }
}
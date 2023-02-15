using System;

namespace LSCode.Validations.Extensions
{
    /// <summary>Provides extension methods that contain validations if one value is smaller than another with boolean returns.</summary>
    public static class IsSmallerThanExtention
    {
        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this sbyte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this byte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this short value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ushort value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this int value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this uint value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this long value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, short comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, int comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, long comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this ulong value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this float value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this double value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, double comparedValue) => (double)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this decimal value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        public static bool IsSmallerThan(this DateTime value, DateTime comparedValue) => value < comparedValue;
    }
}
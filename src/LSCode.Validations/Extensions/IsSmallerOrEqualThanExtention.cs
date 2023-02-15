using System;

namespace LSCode.Validations.Extensions
{
    /// <summary>Provides extension methods that contain validations if one value is smaller or equal than another with boolean returns.</summary>
    public static class IsSmallerOrEqualThanExtention
    {
        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this sbyte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this byte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this short value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqualThan(this ushort value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ushort value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this int value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqualThan(this uint value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this uint value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this long value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, sbyte comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, short comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, int comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqualThan(this ulong value, long comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this ulong value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this float value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqualThan(this double value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, float comparedValue) => value <= (double)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this double value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, float comparedValue) => value <= (decimal)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, double comparedValue) => value <= (decimal)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this decimal value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal. False if not.</returns>
        public static bool IsSmallerOrEqualThan(this DateTime value, DateTime comparedValue) => value <= comparedValue;
    }
}
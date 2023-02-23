using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if one value is lower than another with boolean returns.</summary>
    public static class IsLowerThanExtention
    {
        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this sbyte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this byte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this short value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ushort value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this int value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this uint value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this long value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, sbyte comparedValue) => comparedValue >= 0 && value < (ulong)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, short comparedValue) => comparedValue >= 0 && value < (ulong)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, int comparedValue) => comparedValue >= 0 && value < (ulong)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, long comparedValue) => comparedValue >= 0 && value < (ulong)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this ulong value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this float value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, float comparedValue) => value < (double)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this double value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, ulong comparedValue) => value < 0 || (ulong)value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, float comparedValue) => value < (decimal)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, double comparedValue) => value < (decimal)comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this decimal value, decimal comparedValue) => value < comparedValue;

        /// <summary>Validates if the value is lower than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower. False if not.</returns>
        public static bool IsLowerThan(this DateTime value, DateTime comparedValue) => value < comparedValue;
    }
}
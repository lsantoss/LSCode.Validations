using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if one value is greater than another with boolean returns.</summary>
    public static class IsGreaterThanExtension
    {
        #region ## Region for main value with type sbyte ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, ulong comparedValue) => value >= 0 && (ulong)value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this sbyte value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type byte ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this byte value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type short ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, ulong comparedValue) => value >= 0 && (ulong)value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this short value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type ushort ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ushort value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type int ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, ulong comparedValue) => value >= 0 && (ulong)value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this int value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type uint ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this uint value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type long ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, ulong comparedValue) => value >= 0 && (ulong)value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this long value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type ulong ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, sbyte comparedValue) => comparedValue < 0 || value > (ulong)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, short comparedValue) => comparedValue < 0 || value > (ulong)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, int comparedValue) => comparedValue < 0 || value > (ulong)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, long comparedValue) => comparedValue < 0 || value > (ulong)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this ulong value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type float ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this float value, decimal comparedValue) => (decimal)value > comparedValue;

        #endregion

        #region ## Region for main value with type double ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, float comparedValue) => value > (double)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this double value, decimal comparedValue) => (decimal)value > comparedValue;

        #endregion

        #region ## Region for main value with type decimal ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, float comparedValue) => value > (decimal)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, double comparedValue) => value > (decimal)comparedValue;

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this decimal value, decimal comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type char ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this char value, char comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type DateTime ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this DateTime value, DateTime comparedValue) => value > comparedValue;

        #endregion

        #region ## Region for main value with type TimeSpan ##

        /// <summary>Validates if the value is greater than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if greater. False if not.</returns>
        public static bool IsGreaterThan(this TimeSpan value, TimeSpan comparedValue) => value > comparedValue;

        #endregion
    }
}
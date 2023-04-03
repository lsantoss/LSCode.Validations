using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if one value is lower or equals than another with boolean returns.</summary>
    public static class IsLowerOrEqualsThanExtention
    {
        #region ## Region for main value with type sbyte ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this sbyte value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type byte ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this byte value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type short ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this short value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type ushort ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ushort value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type int ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this int value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type uint ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this uint value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type long ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, ulong comparedValue) => value < 0 || (ulong)value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this long value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type ulong ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, sbyte comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, short comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, int comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, long comparedValue) => comparedValue >= 0 && value <= (ulong)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this ulong value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type float ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, ulong comparedValue) => value < 0 || value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this float value, decimal comparedValue) => (decimal)value <= comparedValue;

        #endregion

        #region ## Region for main value with type double ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, ulong comparedValue) => value < 0 || value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, float comparedValue) => value <= (double)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this double value, decimal comparedValue) => (decimal)value <= comparedValue;

        #endregion

        #region ## Region for main value with type decimal ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, ulong comparedValue) => value < 0 || value <= comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, float comparedValue) => value <= (decimal)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, double comparedValue) => value <= (decimal)comparedValue;

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this decimal value, decimal comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type DateTime ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this char value, char comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type DateTime ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this DateTime value, DateTime comparedValue) => value <= comparedValue;

        #endregion

        #region ## Region for main value with type TimeSpan ##

        /// <summary>Validates if the value is lower or equals than the compared value.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if lower or equals. False if not.</returns>
        public static bool IsLowerOrEqualsThan(this TimeSpan value, TimeSpan comparedValue) => value <= comparedValue;

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain equality validations with boolean returns.</summary>
    public static class IsEqualToExtension
    {
        #region ## Region for main value with type sbyte ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this sbyte value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type byte ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this byte value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type short ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this short value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type ushort ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ushort value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type int ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this int value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type uint ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this uint value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type long ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this long value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type ulong ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, sbyte comparedValue) => value == (ulong)comparedValue && comparedValue >= 0;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, short comparedValue) => value == (ulong)comparedValue && comparedValue >= 0;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, int comparedValue) => value == (ulong)comparedValue && comparedValue >= 0;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, long comparedValue) => value == (ulong)comparedValue && comparedValue >= 0;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this ulong value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type float ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this float value, decimal comparedValue) => (decimal)value == comparedValue;

        #endregion

        #region ## Region for main value with type double ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, float comparedValue) => value == (double)comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this double value, decimal comparedValue) => (decimal)value == comparedValue;

        #endregion

        #region ## Region for main value with type decimal ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, ulong comparedValue) => value >= 0 && (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, float comparedValue) => value == (decimal)comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, double comparedValue) => value == (decimal)comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this decimal value, decimal comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type bool ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this bool value, bool comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type char ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this char value, char comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type string ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this string value, string comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this string value, Guid comparedValue) => value == comparedValue.ToString();

        #endregion

        #region ## Region for main value with type Guid ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this Guid value, Guid comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this Guid value, string comparedValue) => value.ToString() == comparedValue;

        #endregion

        #region ## Region for main value with type DateTime ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this DateTime value, DateTime comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type TimeSpan ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo(this TimeSpan value, TimeSpan comparedValue) => value == comparedValue;

        #endregion

        #region ## Region for main value with type IEnumerable ##

        /// <summary>Validates if two values ​​are equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if equals. False if not.</returns>
        public static bool IsEqualTo<T>(this IEnumerable<T> value, IEnumerable<T> comparedValue)
        {
            if (value == null && comparedValue == null)
                return true;

            if (value == null || comparedValue == null)
                return false;

            if (value.Count() != comparedValue.Count())
                return false;

            return value.SequenceEqual(comparedValue);
        }

        #endregion
    }
}
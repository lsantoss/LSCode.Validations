using System;
using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain difference checks with boolean returns.</summary>
    public static class IsNotEqualToValidationExtension
    {
        #region ## Region for main value with type sbyte ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, ulong comparedValue) => value < 0 || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this sbyte value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type byte ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this byte value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type short ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, ulong comparedValue) => value < 0 || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this short value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type ushort ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ushort value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type int ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, ulong comparedValue) => value < 0 || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this int value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type uint ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this uint value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type long ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, ulong comparedValue) => value < 0 || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this long value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type ulong ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, sbyte comparedValue) => comparedValue < 0 || value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, short comparedValue) => comparedValue < 0 || value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, int comparedValue) => comparedValue < 0 || value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, long comparedValue) => comparedValue < 0 || value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this ulong value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type float ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, ulong comparedValue) => value < 0 || !long.TryParse(value.ToString(), out _) || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this float value, decimal comparedValue) => (decimal)value != comparedValue;

        #endregion

        #region ## Region for main value with type double ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, ulong comparedValue) => value < 0 || !long.TryParse(value.ToString(), out _) || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, float comparedValue) => value != (double)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this double value, decimal comparedValue) => (decimal)value != comparedValue;

        #endregion

        #region ## Region for main value with type decimal ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, ulong comparedValue) => value < 0 || !long.TryParse(value.ToString(), out _) || (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, float comparedValue) => value != (decimal)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, double comparedValue) => value != (decimal)comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this decimal value, decimal comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type bool ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this bool value, bool comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type char ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this char value, char comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type string ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this string value, string comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this string value, Guid comparedValue) => value != comparedValue.ToString();

        #endregion

        #region ## Region for main value with type Guid ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this Guid value, Guid comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
		/// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this Guid value, string comparedValue) => value.ToString() != comparedValue;

        #endregion

        #region ## Region for main value with type DateTime ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this DateTime value, DateTime comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type TimeSpan ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo(this TimeSpan value, TimeSpan comparedValue) => value != comparedValue;

        #endregion

        #region ## Region for main value with type IEnumerable ##

        /// <summary>Validates if two values ​​are not equals.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <param name="comparedValue">Value to be compared with the main value.</param>
        /// <returns>True if not equals. False if is.</returns>
        public static bool IsNotEqualTo<T>(this IEnumerable<T> value, IEnumerable<T> comparedValue)
        {
            if (value == null && comparedValue == null)
                return false;

            if (value == null || comparedValue == null)
                return true;

            if (value.Count() != comparedValue.Count())
                return true;

            return !value.SequenceEqual(comparedValue);
        }

        #endregion
    }
}
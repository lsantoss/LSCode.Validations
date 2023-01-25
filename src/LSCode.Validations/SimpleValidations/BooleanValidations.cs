using System;
using System.Text.RegularExpressions;

namespace LSCode.Validations.SimpleValidations
{
    /// <summary>Helps in the use of Boolean validations.</summary>
    public static class BooleanValidations
    {
        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(sbyte value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(byte value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(short value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ushort value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(int value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(uint value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(long value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value == (ulong)comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, short comparedValue) => comparedValue < 0 ? false : value == (ulong)comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, int comparedValue) => comparedValue < 0 ? false : value == (ulong)comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, long comparedValue) => comparedValue < 0 ? false : value == (ulong)comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, ulong comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(ulong value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, float comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(float value, decimal comparedValue) => (decimal)value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, float comparedValue) => (float)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, double comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(double value, decimal comparedValue) => (decimal)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, sbyte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, byte comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, short comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, ushort comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, int comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, uint comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, long comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, ulong comparedValue) => value < 0 ? false : (ulong)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, float comparedValue) => (float)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, double comparedValue) => (double)value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(decimal value, decimal comparedValue) => value == comparedValue;


        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(bool value, bool comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(string value, string comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(string value, Guid comparedValue) => value == comparedValue.ToString();

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(Guid value, Guid comparedValue) => value == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(Guid value, string comparedValue) => value.ToString() == comparedValue;

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(object value, object comparedValue) => value.Equals(comparedValue);

        /// <summary>Validates if two values ​​are equal.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if equal or False if different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEqual(DateTime value, DateTime comparedValue) => value == comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(sbyte value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(byte value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(short value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ushort value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(int value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(uint value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(long value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, sbyte comparedValue) => comparedValue < 0 ? true : value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, short comparedValue) => comparedValue < 0 ? true : value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, int comparedValue) => comparedValue < 0 ? true : value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, long comparedValue) => comparedValue < 0 ? true : value != (ulong)comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, ulong comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(ulong value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, float comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(float value, decimal comparedValue) => (decimal)value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, float comparedValue) => (float)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, double comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(double value, decimal comparedValue) => (decimal)value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, sbyte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, byte comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, short comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, ushort comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, int comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, uint comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, long comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, float comparedValue) => (float)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, double comparedValue) => (double)value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(decimal value, decimal comparedValue) => value != comparedValue;


        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(bool value, bool comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(string value, string comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(string value, Guid comparedValue) => value != comparedValue.ToString();

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(Guid value, Guid comparedValue) => value != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(Guid value, string comparedValue) => value.ToString() != comparedValue;

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(object value, object comparedValue) => !value.Equals(comparedValue);

        /// <summary>Validates if two values ​​are different.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
		/// <returns>True if different or False if the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsDifferent(DateTime value, DateTime comparedValue) => value != comparedValue;

        //========================================================================================================================================


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(sbyte value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(byte value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(short value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ushort value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(int value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(uint value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(long value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, sbyte comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, short comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, int comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, long comparedValue) => comparedValue < 0 ? true : value >= (ulong)comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, ulong comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(ulong value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, float comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(float value, decimal comparedValue) => (decimal)value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, float comparedValue) => (float)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, double comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(double value, decimal comparedValue) => (decimal)value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, sbyte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, byte comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, short comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, ushort comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, int comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, uint comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, long comparedValue) => value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, ulong comparedValue) => value < 0 ? false : (ulong)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, float comparedValue) => (float)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, double comparedValue) => (double)value >= comparedValue;

        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(decimal value, decimal comparedValue) => value >= comparedValue;


        /// <summary>Validates whether the first value is greater than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreaterOrEqual(DateTime value, DateTime comparedValue) => value >= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(sbyte value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(byte value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(short value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ushort value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(int value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(uint value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(long value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, sbyte comparedValue) => comparedValue < 0 ? true : value > (ulong)comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, short comparedValue) => comparedValue < 0 ? true : value > (ulong)comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, int comparedValue) => comparedValue < 0 ? true : value > (ulong)comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, long comparedValue) => comparedValue < 0 ? true : value > (ulong)comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, ulong comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(ulong value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, float comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(float value, decimal comparedValue) => (decimal)value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, float comparedValue) => (float)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, double comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(double value, decimal comparedValue) => (decimal)value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, sbyte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, byte comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, short comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, ushort comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, int comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, uint comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, long comparedValue) => value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, ulong comparedValue) => value < 0 ? false : (ulong)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, float comparedValue) => (float)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, double comparedValue) => (double)value > comparedValue;

        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(decimal value, decimal comparedValue) => value > comparedValue;


        /// <summary>Validates if the first value is greater than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if greater or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsGreater(DateTime value, DateTime comparedValue) => value > comparedValue;

        //========================================================================================================================================


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(sbyte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(byte value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(short value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ushort value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(int value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(uint value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(long value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, short comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, int comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, long comparedValue) => comparedValue < 0 ? false : value <= (ulong)comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, ulong comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(ulong value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, float comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(float value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, float comparedValue) => (float)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, double comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(double value, decimal comparedValue) => (decimal)value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, sbyte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, byte comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, short comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, ushort comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, int comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, uint comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, long comparedValue) => value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, float comparedValue) => (float)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, double comparedValue) => (double)value <= comparedValue;

        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(decimal value, decimal comparedValue) => value <= comparedValue;


        /// <summary>Validates whether the first value is less than or equal to the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if less than or equal or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmallerOrEqual(DateTime value, DateTime comparedValue) => value <= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(sbyte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(byte value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(short value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ushort value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(int value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(uint value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(long value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, sbyte comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, short comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, int comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, long comparedValue) => comparedValue < 0 ? false : value < (ulong)comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, ulong comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(ulong value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, float comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(float value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, double comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(double value, decimal comparedValue) => (decimal)value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, sbyte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, byte comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, short comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, ushort comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, int comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, uint comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, long comparedValue) => value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, ulong comparedValue) => value < 0 ? true : (ulong)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, float comparedValue) => (float)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, double comparedValue) => (double)value < comparedValue;

        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(decimal value, decimal comparedValue) => value < comparedValue;


        /// <summary>Validates if the first value is less than the second value.</summary>
        /// <param name="value">First value to be compared.</param>
        /// <param name="comparedValue">Second value to be compared.</param>
        /// <returns>True if smaller or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsSmaller(DateTime value, DateTime comparedValue) => value <= comparedValue;

        //========================================================================================================================================


        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if false or False if true.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsFalse(bool value) => value == false;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if true or False if false.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsTrue(bool value) => value == true;

        //========================================================================================================================================  


        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsNull(object value) => value == null;

        /// <summary>Validates if value is or empty.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or empty. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsNullOrEmpty(string value) => string.IsNullOrEmpty(value);

        /// <summary>Validates if value is or empty or white spaces.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null, empty or white spaces. False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsNullOrEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>Validates if the value contains a text snippet.</summary>
        /// <param name="value">Main text.</param>
        /// <param name="text">Text that will be checked if it is contained in the main text.</param>
        /// <returns>True if the value contains a snippet of text or False if it does not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool Contains(string value, string text) => value != null && text != null && value.Contains(text);

        /// <summary>Validates if the text length is equal to the expected length.</summary>
        /// <param name="value">Text.</param>
        /// <param name="length">Expected text length.</param>
        /// <returns>True if the text length is the same or False if it is different.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool HasEqualLength(string value, int length) => value != null && value.Length == length;

        /// <summary>Validates if the text length is different from the expected length.</summary>
        /// <param name="value">Text.</param>
        /// <param name="length">Unexpected text length.</param>
        /// <returns>True if the text length is different or False if it is the same.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool HasDifferentLength(string value, int length) => value != null && value.Length != length;

        /// <summary>Validates if the maximum text length has been reached.</summary>
        /// <param name="value">Text.</param>
        /// <param name="maximumLenght">Maximum expected length for text.</param>
        /// <returns>True if the maximum text length has been reached or False if it has been reached.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool HasMaximumLength(string value, int maximumLenght) => value != null && value.Length <= maximumLenght;

        /// <summary>Validates if the minimum text length has been reached.</summary>
        /// <param name="value">Text.</param>
        /// <param name="minimumLength">Minimum expected text length.</param>
        /// <returns>True if the minimum text length has been reached or False if not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool HasMinimumLength(string value, int minimumLength) => value != null && value.Length >= minimumLength;

        /// <summary>Validates if the url is valid.</summary>
        /// <param name="value">URL that will be validated.</param>
        /// <returns>True if it's a url or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsUrl(string value) => Uri.IsWellFormedUriString(value, UriKind.Absolute);

        /// <summary>Validates whether the url is valid or empty.</summary>
        /// <param name="value">URL that will be validated.</param>
        /// <returns>True if it's a url or empty or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsUrlOrEmpty(string value) => Uri.IsWellFormedUriString(value, UriKind.Absolute) || value == "";

        /// <summary>Validates if the email is valid.</summary>
        /// <param name="email">Email that will be validated.</param>
        /// <returns>True if it's an email or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEmail(string email) => email != null && Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        /// <summary>Validates whether the email is valid or empty.</summary>
        /// <param name="email">Email that will be validated.</param>
        /// <returns>True if it's an email or empty or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsEmailOrEmpty(string email) => email != null && (Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$") || email == "");

        /// <summary>Validate the mobile number.</summary>
        /// <param name="value">Cellphone number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsCellphone(string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        /// <summary>Validates the phone number.</summary>
        /// <param name="value">Telephone number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsTelephone(string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        /// <summary>Validates the CEP number.</summary>
        /// <param name="value">CEP.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsCEP(string value) => value != null && Regex.IsMatch(value, @"^\d{5}\-?\d{3}$");

        /// <summary>Validates the CNPJ number.</summary>
        /// <param name="value">CNPJ number.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsCNPJ(string value)
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
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsCPF(string value)
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
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool ContainsLetter(string value) => Regex.IsMatch(value, @"[a-z]+|[A-Z]+");

        /// <summary>Validates if the text has at least one capital letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool ContainsCapitalLetter(string value) => Regex.IsMatch(value, @"[A-Z]+");

        /// <summary>Validates if the text has at least one lowercase letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool ContainsLowercaseLetter(string value) => Regex.IsMatch(value, @"[a-z]+");

        /// <summary>Validates if the text has at least one number.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool ContainsNumber(string value) => Regex.IsMatch(value, @"[0-9]+");

        /// <summary>Validates if the text has at least one special character.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool ContainsSpecialCharacter(string value) => Regex.IsMatch(value, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

        /// <summary>Validates if the text is composed only of numbers.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid or False if invalid.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsOnlyNumbers(string value) => Regex.IsMatch(value, @"^[0-9]+$");

        /// <summary>Validates whether the date is a weekday.</summary>
        /// <param name="date">Date to be validated.</param>
        /// <returns>True if it's a weekday or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsWeekday(DateTime date) => date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;

        /// <summary>Validates if the date is a weekend.</summary>
        /// <param name="date">Date to be validated.</param>
        /// <returns>True if it's a weekend or False if it's not.</returns>
        /// <exception cref="Exception">Error during validation.</exception>
        public static bool IsWeekend(DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}
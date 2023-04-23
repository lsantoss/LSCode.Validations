using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations that check that the length of variables is not the same as desired with boolean returns.</summary>
    public static class HasNotLengthEqualToExtension
    {
        #region ## Region for main value with type string ##

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, sbyte lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, byte lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, short lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, ushort lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, int lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, uint lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, long lenght) => value == null || value.Length != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo(this string value, ulong lenght) => value == null || (ulong)value.Length != lenght;

        #endregion

        #region ## Region for main value with type IEnumerable ##

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, sbyte lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, byte lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, short lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, ushort lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, int lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, uint lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, long lenght) => value == null || value.Count() != lenght;

        /// <summary>Validates if the length is not the same as indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is not equal. False if equal.</returns>
        public static bool HasNotLengthEqualTo<T>(this IEnumerable<T> value, ulong lenght) => value == null || (ulong)value.Count() != lenght;

        #endregion
    }
}
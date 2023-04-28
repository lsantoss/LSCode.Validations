using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations that check if the variable's length is lower than indicated with boolean returns.</summary>
    public static class HasLengthLowerThanValidationExtension
    {
        #region ## Region for main value with type string ##

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, sbyte lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, byte lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, short lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, ushort lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, int lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, uint lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, long lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan(this string value, ulong lenght) => value != null && (ulong)value.Length < lenght;

        #endregion

        #region ## Region for main value with type IEnumerable ##

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, sbyte lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, byte lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, short lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, ushort lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, int lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, uint lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, long lenght) => value != null && value.Count() < lenght;

        /// <summary>Validates if the length is lower than indicated.</summary>
        /// <typeparam name="T">List generic type.</typeparam>
        /// <param name="value">Value to be used for comparison.</param>
        /// <param name="lenght">Indicated length.</param>
        /// <returns>True if the value is lower. False if not lower.</returns>
        public static bool HasLengthLowerThan<T>(this IEnumerable<T> value, ulong lenght) => value != null && (ulong)value.Count() < lenght;

        #endregion
    }
}
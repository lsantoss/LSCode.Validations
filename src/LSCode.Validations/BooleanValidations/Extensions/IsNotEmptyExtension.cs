using System;
using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNotEmptyExtension
    {
        /// <summary>Validates if value is not empty.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not empty. False if the value is empty.</returns>
        public static bool IsNotEmpty(this char value) => value != ' ';

        /// <summary>Validates if value is not empty.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not empty. False if the value is empty.</returns>
        public static bool IsNotEmpty(this string value) => value != string.Empty;

        /// <summary>Validates if value is not empty.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not empty. False if the value is empty.</returns>
        public static bool IsNotEmpty(this Guid value) => value != Guid.Empty;

        /// <summary>Validates if value is not empty.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not empty. False if the value is empty.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> value) => value.Count() > 0;
    }
}
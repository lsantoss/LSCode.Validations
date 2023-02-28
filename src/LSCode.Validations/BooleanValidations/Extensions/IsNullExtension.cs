using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNullExtension
    {
        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this sbyte? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this byte? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this short? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this ushort? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this int? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this uint? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this long? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this ulong? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this float? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this double? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this decimal? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this bool? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this char? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this string value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this Guid? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this DateTime? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this TimeSpan? value) => value == null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this object value) => value == null;
    }
}
using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value is null with boolean returns.</summary>
    public static class IsNotNullExtension
    {
        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this sbyte? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this byte? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this short? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this ushort? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this int? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this uint? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this long? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this ulong? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this float? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this double? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this decimal? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this bool? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this char? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this string value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this Guid? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this DateTime? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this TimeSpan? value) => value != null;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this object value) => value != null;
    }
}
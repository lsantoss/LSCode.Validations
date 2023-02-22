namespace LSCode.Validations.SimpleValidations.Extensions
{
    public static class BoolValidationExtension
    {
        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is false. False if the value is true.</returns>
        public static bool IsFalse(this bool value) => value == false;

        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True  if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this bool? value) => value != null;

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this bool? value) => value == null;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is true. False if the value is false.</returns>
        public static bool IsTrue(this bool value) => value == true;
    }
}
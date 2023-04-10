namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsTrueOrFalseExtension
    {
        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is false. False if the value is true.</returns>
        public static bool IsFalse(this bool value) => value == false;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is true. False if the value is false.</returns>
        public static bool IsTrue(this bool value) => value == true;
    }
}
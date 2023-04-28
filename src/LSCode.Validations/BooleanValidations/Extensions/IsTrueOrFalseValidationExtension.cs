namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsTrueOrFalseValidationExtension
    {
        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if the value is false. False if the value is true.</returns>
        public static bool IsFalse(this bool value) => value == false;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if the value is true. False if the value is false.</returns>
        public static bool IsTrue(this bool value) => value == true;
    }
}
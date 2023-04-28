namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value is not null with boolean returns.</summary>
    public static class IsNullValidationExtension
    {
        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this object value) => value == null;
    }
}
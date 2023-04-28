namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations if a value is null with boolean returns.</summary>
    public static class IsNotNullValidationExtension
    {        
        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Value to be used for comparison.</param>
        /// <returns>True if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this object value) => value != null;
    }
}
namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsEmptyExtension
    {
        /// <summary>Validates if value is empty.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is empty. False if the value is not empty.</returns>
        public static bool IsEmpty(this string value) => value == string.Empty;
    }
}
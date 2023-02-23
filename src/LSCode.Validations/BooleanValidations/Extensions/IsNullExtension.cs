namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNullExtension
    {

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True if the value is null. False if the value is not null.</returns>
        public static bool IsNull(this bool? value) => value == null;
    }
}
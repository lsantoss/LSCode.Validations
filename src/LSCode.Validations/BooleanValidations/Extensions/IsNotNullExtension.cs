namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class IsNotNullExtension
    {
        /// <summary>Validates if value is not null.</summary>
        /// <param name="value">Main value, based on which the comparison will be made.</param>
        /// <returns>True  if the value is not null. False if the value is null.</returns>
        public static bool IsNotNull(this bool? value) => value != null;
    }
}
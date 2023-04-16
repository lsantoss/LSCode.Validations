namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to addresses with boolean returns.</summary>
    public static class IsNotAdressExtension
    {
        /// <summary>Validates if the CEP number is invalid.</summary>
        /// <remarks>
        ///     Invalid formats: CEP with any format different than those mentioned below. <br></br>
        ///     With mask: 00000-000 <br></br>
        ///     Without mask: 00000000
        /// </remarks>
        /// <param name="value">CEP that will be validated.</param>
        /// <returns>True if not a CEP. False if it is.</returns>
        public static bool IsNotCEP(this string value) => !IsAdressExtension.IsCEP(value);
    }
}
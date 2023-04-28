using LSCode.Validations.Constants;
using System.Text.RegularExpressions;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to addresses with boolean returns.</summary>
    public static class IsAdressValidationExtension
    {
        /// <summary>Validates if the CEP number is valid.</summary>
        /// <remarks>
        ///     Valid formats: CEP with or without mask. <br></br>
        ///     With mask: 00000-000 <br></br>
        ///     Without mask: 00000000
        /// </remarks>
        /// <param name="value">CEP that will be validated.</param>
        /// <returns>True if it is a CEP. False if not.</returns>
        public static bool IsCEP(this string value) => Regex.IsMatch(value ?? "", RegexPatterns.CEP);
    }
}
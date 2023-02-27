using LSCode.Validations.Constants;
using LSCode.Validations.RegexValidations;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    public static class AdressesExtension
    {
        /// <summary>Validates the CEP number.</summary>
        /// <remarks>
        ///     Valid formats: CEP with or without mask. <br></br>
        ///     With mask: 00000-000 <br></br>
        ///     Without mask: 00000000
        /// </remarks>
        /// <param name="value">CEP.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool IsCEP(this string value) => RegexValidation.IsMatch(value, RegexPatterns.CEP);

    }
}
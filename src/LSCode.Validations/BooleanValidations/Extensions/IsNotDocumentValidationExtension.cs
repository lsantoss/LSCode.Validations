namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to documents with boolean returns.</summary>
    public static class IsNotDocumentValidationExtension
    {
        /// <summary>Validates if the Passport number is invalid.</summary>
        /// <remarks>
        ///     Invalid formats: Brazilian passport with any format different than those mentioned below. <br></br>
        ///     Position 0 and 1 : Two letters from A to Z in upper case <br></br>
        ///     Position 2 and 7 : Six numbers from 0 to 9 <br></br>
        ///     Example          : AA000000     
        /// </remarks>
        /// <param name="value">Passport number that will be validated.</param>
        /// <returns>True if not a brazilian passport. False if it is.</returns>
        public static bool IsNotBrazilianPassport(this string value) => !IsDocumentValidationExtension.IsBrazilianPassport(value);

        /// <summary>Validates if the CNPJ number is valid.</summary>
        /// <remarks>
        ///     Valid formats: CNPJ with or without mask. <br></br>
        ///     With mask: 00.000.000/0000-00 <br></br>
        ///     Without mask: 00000000000000
        /// </remarks>
        /// <param name="value">CNPJ number that will be validated.</param>
        /// <returns>True if not a CNPJ. False if it is.</returns>
        public static bool IsNotCNPJ(this string value) => !IsDocumentValidationExtension.IsCNPJ(value);

        /// <summary>Validates if the CPF number is valid.</summary>
        /// <remarks>
        ///     Valid formats: CPF with or without mask. <br></br>
        ///     With mask: 000.000.000-00 <br></br>
        ///     Without mask: 00000000000
        /// </remarks>
        /// <param name="value">CPF number that will be validated.</param>
        /// <returns>True if not a CPF. False if it is.</returns>
        public static bool IsNotCPF(this string value) => !IsDocumentValidationExtension.IsCPF(value);
    }
}
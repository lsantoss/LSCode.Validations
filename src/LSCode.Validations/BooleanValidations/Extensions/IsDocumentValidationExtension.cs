using LSCode.Validations.Constants;
using System.Text.RegularExpressions;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to documents with boolean returns.</summary>
    public static class IsDocumentValidationExtension
    {
        /// <summary>Validates if the Passport number is valid.</summary>
        /// <remarks>
        ///     Valid formats: <br></br>
        ///     Position 0 and 1 : Two letters from A to Z in upper case <br></br>
        ///     Position 2 and 7 : Six numbers from 0 to 9 <br></br>
        ///     Example          : AA000000     
        /// </remarks>
        /// <param name="value">Passport number that will be validated.</param>
        /// <returns>True if it is a brazilian passport. False if not.</returns>
        public static bool IsBrazilianPassport(this string value) => Regex.IsMatch(value ?? "", RegexPatterns.BrazilianPassport);

        /// <summary>Validates if the CNPJ number is valid.</summary>
        /// <remarks>
        ///     Valid formats: CNPJ with or without mask. <br></br>
        ///     With mask: 00.000.000/0000-00 <br></br>
        ///     Without mask: 00000000000000
        /// </remarks>
        /// <param name="value">CNPJ number that will be validated.</param>
        /// <returns>True if it is a CNPJ. False if not.</returns>
        public static bool IsCNPJ(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            if (value.Length != 14 && value.Length != 18)
                return false;

            if (value.Length == 18 && (value[2] != '.' || value[6] != '.' || value[10] != '/' || value[15] != '-'))
                return false;

            value = value.Trim().Replace(".", "").Replace("/", "").Replace("-", "");

            if (value.Length != 14)
                return false;

            if (value == "00000000000000" || value == "11111111111111" ||
                value == "22222222222222" || value == "33333333333333" ||
                value == "44444444444444" || value == "55555555555555" ||
                value == "66666666666666" || value == "77777777777777" ||
                value == "88888888888888" || value == "99999999999999")
                return false;

            var mt1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var mt2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var sum = 0;

            var tempCNPJ = value[..12];

            for (var i = 0; i < 12; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt1[i];

            var rest = sum % 11;
            rest = rest < 2 ? 0 : 11 - rest;

            var digit = rest.ToString();

            tempCNPJ += digit;
            sum = 0;
            for (var i = 0; i < 13; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt2[i];

            rest = sum % 11;
            rest = rest < 2 ? 0 : 11 - rest;

            digit += rest.ToString();

            return value.EndsWith(digit);
        }

        /// <summary>Validates if the CPF number is valid.</summary>
        /// <remarks>
        ///     Valid formats: CPF with or without mask. <br></br>
        ///     With mask: 000.000.000-00 <br></br>
        ///     Without mask: 00000000000
        /// </remarks>
        /// <param name="value">CPF number that will be validated.</param>
        /// <returns>True if it is a CPF. False if not.</returns>
        public static bool IsCPF(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            if (value.Length != 11 && value.Length != 14)
                return false;

            if (value.Length == 14 && (value[3] != '.' || value[7] != '.' || value[11] != '-'))
                return false;

            value = value.Trim().Replace(".", "").Replace("-", "");

            if (value.Length != 11)
                return false;

            var position = 0;
            var totalDigit1 = 0;
            var totalDigit2 = 0;
            var dv1 = 0;
            var dv2 = 0;
            var identicalDigits = true;
            var lastDigit = -1;

            foreach (var character in value)
            {
                if (char.IsDigit(character))
                {
                    var digit = character - '0';

                    if (position != 0 && lastDigit != digit)
                        identicalDigits = false;

                    lastDigit = digit;

                    if (position < 9)
                    {
                        totalDigit1 += digit * (10 - position);
                        totalDigit2 += digit * (11 - position);
                    }
                    else if (position == 9)
                        dv1 = digit;
                    else if (position == 10)
                        dv2 = digit;

                    position++;
                }
            }

            if (position > 11)
                return false;

            if (identicalDigits)
                return false;

            var digit1 = totalDigit1 % 11;
            digit1 = digit1 < 2 ? 0 : 11 - digit1;

            if (dv1 != digit1)
                return false;

            totalDigit2 += digit1 * 2;
            var digit2 = totalDigit2 % 11;
            digit2 = digit2 < 2 ? 0 : 11 - digit2;

            return dv2 == digit2;
        }
    }
}
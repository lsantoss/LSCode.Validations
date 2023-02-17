using System;
using System.Text.RegularExpressions;

namespace LSCode.Validations.Extensions
{
    /// <summary>Provides extension methods that contain validations and strings with boolean returns.</summary>
    public static class StringExtension
    {
        /// <summary>Validates if the text has at least one capital letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsCapitalLetter(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"[A-Z]+");

        /// <summary>Validates if the text has at least one letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsLetter(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"[a-z]+|[A-Z]+");

        /// <summary>Validates if the text has at least one lowercase letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsLowercaseLetter(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"[a-z]+");

        /// <summary>Validates if the text has at least one number.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsNumber(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"[0-9]+");

        /// <summary>Validates if the text is composed only of capital letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsOnlyCapitalLetters(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[A-Z]+$");

        /// <summary>Validates if the text is composed only of letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsOnlyLetters(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[a-zA-Z]+$");

        /// <summary>Validates if the text is composed only of capital letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsOnlyLowercaseLetters(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[a-z]+$");

        /// <summary>Validates if the text is composed only of numbers.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsOnlyNumbers(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^[0-9]+$");

        /// <summary>Validates if the text has at least one special character.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool ContainsSpecialCharacter(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

        /// <summary>Validates if the value contains a text snippet.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="text">Text that will be checked if it is contained in the main text.</param>
        /// <returns>True if the value contains a snippet of text or False if it does not.</returns>
        public static bool ContainsText(this string value, string text) => !string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(text) && value.Contains(text);

        /// <summary>Validates if the text length is different to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="length">Unexpected text length.</param>
        /// <returns>True if the text length is different or False if it is the same.</returns>
        public static bool HasDifferentLengthThan(this string value, int length) => value != null && value.Length != length;

        /// <summary>Validates if the text length is equal to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="length">Expected text length.</param>
        /// <returns>True if the text length is the same or False if it is different.</returns>
        public static bool HasEqualLengthThan(this string value, int length) => value != null && value.Length == length;

        /// <summary>Validates if the email is valid.</summary>
        /// <param name="value">Email that will be validated.</param>
        /// <returns>True if it's an email; False if not.</returns>
        public static bool IsEmail(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

        /// <summary>Validates if value is null.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or False if not.</returns>
        public static bool IsNull(this object value) => value == null;

        /// <summary>Validates if value is null or empty.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null or empty. False if not.</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        /// <summary>Validates if value is null or empty or white spaces.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if the value is null, empty or white spaces. False if not.</returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>Validates if the url is valid.</summary>
        /// <param name="value">URL that will be validated.</param>
        /// <returns>True if it's a url; False if not.</returns>
        public static bool IsUrl(this string value) => !string.IsNullOrWhiteSpace(value) && Uri.IsWellFormedUriString(value, UriKind.Absolute);







        /// <summary>Validates if the text length is greater or equal to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="maximumLenght">Expected text length.</param>
        /// <returns>True if the text length is greater or equal; False if not.</returns>
        public static bool HasGreaterOrEqualLengthThan(this string value, int maximumLenght) => value != null && value.Length <= maximumLenght;

        /// <summary>Validates if the minimum text length has been reached.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="minimumLength">Expected text length.</param>
        /// <returns>True if the minimum text length has been reached; False if not.</returns>
        public static bool HasMinimumLength(this string value, int minimumLength) => value != null && value.Length >= minimumLength;

        /// <summary>Validate the mobile number.</summary>
        /// <param name="value">Cellphone number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCellphone(this string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        /// <summary>Validates the phone number.</summary>
        /// <param name="value">Telephone number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsTelephone(this string value) => value != null && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        /// <summary>Validates the CEP number.</summary>
        /// <param name="value">CEP.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCEP(this string value) => value != null && Regex.IsMatch(value, @"^\d{5}\-?\d{3}$");

        /// <summary>Validates the CNPJ number.</summary>
        /// <param name="value">CNPJ number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCNPJ(this string value)
        {
            var mt1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var mt2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum; int rest; string digit; string tempCNPJ;

            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");

            if (value.Length != 14)
                return false;

            if (value == "00000000000000" || value == "11111111111111" ||
                value == "22222222222222" || value == "33333333333333" ||
                value == "44444444444444" || value == "55555555555555" ||
                value == "66666666666666" || value == "77777777777777" ||
                value == "88888888888888" || value == "99999999999999")
                return false;

            tempCNPJ = value.Substring(0, 12);
            sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt1[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = rest.ToString();

            tempCNPJ += digit;
            sum = 0;
            for (int i = 0; i < 13; i++)
                sum += int.Parse(tempCNPJ[i].ToString()) * mt2[i];

            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit += rest.ToString();

            return value.EndsWith(digit);
        }

        /// <summary>Validates the CPF number.</summary>
        /// <param name="value">CPF number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCPF(this string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");

            if (value == null)
                return false;

            var posicao = 0;
            var totalDigito1 = 0;
            var totalDigito2 = 0;
            var dv1 = 0;
            var dv2 = 0;

            var digitosIdenticos = true;
            var ultimoDigito = -1;

            foreach (var c in value)
            {
                if (char.IsDigit(c))
                {
                    var digito = c - '0';
                    if (posicao != 0 && ultimoDigito != digito)
                        digitosIdenticos = false;

                    ultimoDigito = digito;
                    if (posicao < 9)
                    {
                        totalDigito1 += digito * (10 - posicao);
                        totalDigito2 += digito * (11 - posicao);
                    }
                    else if (posicao == 9)
                        dv1 = digito;
                    else if (posicao == 10)
                        dv2 = digito;

                    posicao++;
                }
            }

            if (posicao > 11)
                return false;

            if (digitosIdenticos)
                return false;

            var digito1 = totalDigito1 % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            if (dv1 != digito1)
                return false;

            totalDigito2 += digito1 * 2;
            var digito2 = totalDigito2 % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            return dv2 == digito2;
        }
    }
}
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

        /// <summary>Validates if the text length is greater to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="lenght">Expected text length.</param>
        /// <returns>True if the text length is greater; False if not.</returns>
        public static bool HasGreaterLengthThan(this string value, int lenght) => value != null && value.Length > lenght;

        /// <summary>Validates if the text length is greater or equal to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="lenght">Expected text length.</param>
        /// <returns>True if the text length is greater or equal; False if not.</returns>
        public static bool HasGreaterOrEqualLengthThan(this string value, int lenght) => value != null && value.Length >= lenght;

        /// <summary>Validates if the text length is smaller to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="lenght">Expected text length.</param>
        /// <returns>True if the text length is smaller; False if not.</returns>
        public static bool HasSmallerLengthThan(this string value, int lenght) => value != null && value.Length < lenght;

        /// <summary>Validates if the text length is smaller or equal to the expected.</summary>
        /// <param name="value">Text to be checked.</param>
        /// <param name="lenght">Expected text length.</param>
        /// <returns>True if the text length is smaller o equal; False if not.</returns>
        public static bool HasSmallerOrEqualLengthThan(this string value, int lenght) => value != null && value.Length <= lenght;

        /// <summary>Validates the CEP number.</summary>
        /// <remarks>
        ///     Valid formats: CEP with or without mask. <br></br>
        ///     With mask: 00000-000 <br></br>
        ///     Without mask: 00000000
        /// </remarks>
        /// <param name="value">CEP.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCEP(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^\d{5}\-?\d{3}$");

        /// <summary>Validates the CNPJ number.</summary>
        /// <remarks>
        ///     Valid formats: CNPJ with or without mask. <br></br>
        ///     With mask: 00.000.000/0000-00 <br></br>
        ///     Without mask: 00000000000000
        /// </remarks>
        /// <param name="value">CNPJ number.</param>
        /// <returns>True if valid; False if invalid.</returns>
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

        /// <summary>Validates the CPF number.</summary>
        /// <remarks>
        ///     Valid formats: CPF with or without mask. <br></br>
        ///     With mask: 000.000.000-00 <br></br>
        ///     Without mask: 00000000000
        /// </remarks>
        /// <param name="value">CPF number.</param>
        /// <returns>True if valid; False if invalid.</returns>
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











        /// <summary>Validate the mobile number.</summary>
        /// <param name="value">Cellphone number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsCellphone(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$");

        /// <summary>Validates the phone number.</summary>
        /// <remarks>
        ///     Valid formats: Phone number with or without mask. <br></br>
        ///     With mask: +55 (11) 2222-3333 <br></br>
        ///     Without mask: 551122223333
        /// </remarks>
        /// <param name="value">Telephone number.</param>
        /// <returns>True if valid; False if invalid.</returns>
        public static bool IsTelephone(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");
        //public static bool IsTelephone(this string value) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, @"^\+?55 ?\(?[1-9]{2}\)? ?[2-8][0-9]{3}\-?[0-9]{4}$");
    }
}
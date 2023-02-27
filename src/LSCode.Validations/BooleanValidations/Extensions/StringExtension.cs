﻿using LSCode.Validations.Constants;
using LSCode.Validations.RegexValidations;
using System;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations and strings with boolean returns.</summary>
    public static class StringExtension
    {
        /// <summary>Validates if the text has at least one capital letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsCapitalLetter(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsCapitalLetter);

        /// <summary>Validates if the text has at least one letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsLetter(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsLetter);

        /// <summary>Validates if the text has at least one lowercase letter.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsLowercaseLetter(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsLowercaseLetter);

        /// <summary>Validates if the text has at least one number.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsNumber(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsNumber);

        /// <summary>Validates if the text is composed only of capital letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsOnlyCapitalLetters(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsOnlyCapitalLetters);

        /// <summary>Validates if the text is composed only of letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsOnlyLetters(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsOnlyLetters);

        /// <summary>Validates if the text is composed only of capital letters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsOnlyLowercaseLetters(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsOnlyLowercaseLetters);

        /// <summary>Validates if the text is composed only of numbers.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsOnlyNumbers(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsOnlyNumbers);

        /// <summary>Validates if the text is composed only of special characters.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsOnlySpecialCharacters(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsOnlySpecialCharacters);

        /// <summary>Validates if the text has at least one special character.</summary>
        /// <param name="value">Text that will be validated.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool ContainsSpecialCharacter(this string value) => RegexValidation.IsMatch(value, RegexPatterns.ContainsSpecialCharacter);

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
    }
}
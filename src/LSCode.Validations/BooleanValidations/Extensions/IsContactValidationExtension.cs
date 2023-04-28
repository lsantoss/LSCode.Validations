using LSCode.Validations.Constants;
using System.Text.RegularExpressions;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to contacts with boolean returns.</summary>
    public static class IsContactValidationExtension
    {
        /// <summary>Validates if the mobile number is valid.</summary>
        /// <remarks>
        ///     Valid formats: <br></br>
        ///     Position 0 and 1     : Brazilian DDI - 55 <br></br>
        ///     Position 2 and 3     : Valid Brazilian DDD - 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 31, 32, 33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53, 54, 55, 61, 62, 63, 64, 65, 66, 67, 68, 69, 71, 73, 74, 75, 77, 79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96, 97, 98, 99 <br></br>
        ///     Position 4           : Number 9  <br></br>
        ///     Position from 5      : Number from 1 to 9 <br></br>
        ///     Position from 6 to 12: Number from 0 to 9 <br></br>
        ///     Without mask         : 5511922223333
        /// </remarks>
        /// <param name="value">Mobile number that will be validated.</param>
        /// <returns>True if it is a mobile number. False if not.</returns>
        public static bool IsBrazilianCellphone(this string value) => Regex.IsMatch(value ?? "", RegexPatterns.BrazilianCellphone);

        /// <summary>Validates if the phone number is valid.</summary>
        /// <remarks>
        ///     Valid formats: <br></br>
        ///     Position 0 and 1     : Brazilian DDI - 55 <br></br>
        ///     Position 2 and 3     : Valid Brazilian DDD - 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 31, 32, 33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53, 54, 55, 61, 62, 63, 64, 65, 66, 67, 68, 69, 71, 73, 74, 75, 77, 79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96, 97, 98, 99 <br></br>
        ///     Position 4           : Number from 2 to 8  <br></br>
        ///     Position from 5 to 11: Number from 0 to 9 <br></br>
        ///     Without mask         : 551122223333
        /// </remarks>
        /// <param name="value">Phone number that will be validated.</param>
        /// <returns>True if it is a phone number. False if not.</returns>
        public static bool IsBrazilianTelephone(this string value) => Regex.IsMatch(value ?? "", RegexPatterns.BrazilianTelephone);

        /// <summary>Validates if the email is valid.</summary>
        /// <param name="value">Email that will be validated.</param>
        /// <returns>True if it is a email. False if not.</returns>
        public static bool IsEmail(this string value) => Regex.IsMatch(value ?? "", RegexPatterns.Email);
    }
}
using LSCode.Validations.Constants;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to payment methods with boolean returns.</summary>
    public static class IsPaymentMethodValidationExtension
    {
        /// <summary>Validates if the credit card is valid.</summary>
        /// <remarks>Valid formats: Credit Card with or without mask.</remarks>
        /// <param name="value">Credit card number that will be validated.</param>
        /// <returns>True if it is a credit card number. False if not.</returns>
        public static bool IsCreditCard(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) 
                return false;

            value = Regex.Replace(value, RegexPatterns.ExceptNumbers, string.Empty);

            if (string.IsNullOrWhiteSpace(value))
                return false;

            var even = false;
            var checksum = 0;

            foreach (var digit in value.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                    return false;

                var val = (digit - '0') * (even ? 2 : 1);
                even = !even;

                while (val > 0)
                {
                    checksum += val % 10;
                    val /= 10;
                }
            }

            if (checksum % 10 != 0)
                return false;

            return true;
        }
    }
}
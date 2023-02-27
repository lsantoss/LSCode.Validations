using LSCode.Validations.Constants;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations of payment methods with boolean returns.</summary>
    public static class PaymentMethodsExtension
    {
        /// <summary>Validate the credit card.</summary>
        /// <remarks>Valid formats: Credit Card with or without mask.</remarks>
        /// <param name="value">Credit card number.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public static bool IsCreditCard(this string value)
        {
            if (string.IsNullOrEmpty(value)) 
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
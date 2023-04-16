namespace LSCode.Validations.BooleanValidations.Extensions
{
    /// <summary>Provides extension methods that contain validations related to payment methods with boolean returns.</summary>
    public static class IsNotPaymentMethodExtension
    {
        /// <summary>Validates if the credit card is invalid.</summary>
        /// <param name="value">Credit card number that will be validated.</param>
        /// <returns>True if not a credit card number. False if it is.</returns>
        public static bool IsNotCreditCard(this string value) => !IsPaymentMethodExtension.IsCreditCard(value);
    }
}
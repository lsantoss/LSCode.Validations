using LSCode.Validations.NotifiableValidations;
using LSCode.Validations.SimpleValidations;
using System;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords with four numeric digits.</summary>
    public class FourNumbersPassword : Notifier
    {
        /// <value>Password with four numeric digits.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the FourNumbersPassword class.</summary>
        /// <remarks>Must contain four numeric digits.</remarks>
        /// <param name="value">Password with four numeric digits.</param>
        /// <returns>Create an instance of the FourNumbersPassword class.</returns>
        public FourNumbersPassword(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("Password", "Password cannot be null or empty");
                else
                {
                    if (!BooleanValidations.HasMaximumLength(value, 4))
                        AddNotification("Password", "Password must contain a maximum of 4 characters");

                    if (!BooleanValidations.IsOnlyNumbers(value))
                        AddNotification("Password", "Password must contain only numeric digits");
                }
            }
            catch (Exception ex)
            {
                AddNotification("Password", $"Error: {ex.Message}");
            }
        }

        /// <summary>Return password with four numeric digits.</summary>
        public override string ToString() => Value;
    }
}
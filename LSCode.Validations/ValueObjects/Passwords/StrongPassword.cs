using LSCode.Validations.NotifiableValidations;
using LSCode.Validations.SimpleValidations;
using System;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class StrongPassword : Notifier
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>StrongPassword class constructor.</summary>
        /// <remarks>It must contain at least eight and at most fifteen characters; An uppercase letter; A lowercase letter; A number; a special character.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Create an instance of the StrongPassword class.</returns>
        public StrongPassword(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("Password", "Password cannot be null or empty");
                else
                {
                    if (!BooleanValidations.HasMinimumLength(Value, 8))
                        AddNotification("Password", "Password must contain at least 8 characters");

                    if (!BooleanValidations.HasMaximumLength(Value, 15))
                        AddNotification("Password", "Password must contain a maximum of 15 characters");

                    if (!BooleanValidations.ContainsCapitalLetter(Value))
                        AddNotification("Password", "Password must contain at least 1 capital letter");

                    if (!BooleanValidations.ContainsLowercaseLetter(Value))
                        AddNotification("Password", "Password must contain at least 1 lowercase letter");

                    if (!BooleanValidations.ContainsNumber(Value))
                        AddNotification("Password", "Password must contain at least 1 number");

                    if (!BooleanValidations.ContainsSpecialCharacter(Value))
                        AddNotification("Password", "Password must contain at least 1 special character");
                }
            }
            catch (Exception ex)
            {
                AddNotification("Password", $"Error: {ex.Message}");
            }
        }

        /// <summary>Return password.</summary>
        public override string ToString() => Value;
    }
}
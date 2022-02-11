using LSCode.Validations.NotifiableValidations;
using LSCode.Validations.SimpleValidations;
using System;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class VeryWeakPassword : Notifier
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>VeryWeakPassword class constructor.</summary>
        /// <remarks>Must contain at least six and at most fifteen characters.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Creates an instance of the VeryWeakPassword class.</returns>
        public VeryWeakPassword(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("Password", "Password cannot be null or empty");
                else
                {
                    if (!BooleanValidations.HasMinimumLength(value, 6))
                        AddNotification("Password", "Password must contain at least 6 characters");

                    if (!BooleanValidations.HasMaximumLength(value, 15))
                        AddNotification("Password", "Password must contain a maximum of 15 characters");
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
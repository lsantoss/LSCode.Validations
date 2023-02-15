using LSCode.Validations.Extensions;
using LSCode.Validations.Notifiable;
using System;

namespace LSCode.Validations.ValueObjects.Contacts
{
    /// <summary>Assists in the use and validation of emails.</summary>
    public class Email : Notifier
    {
        /// <value>Email address.</value>
        public string Value { get; private set; }

        /// <summary>Email class constructor.</summary>
        /// <remarks>Valid formats: Standard email format.</remarks>
        /// <param name="value">Email address.</param>
        /// <returns>Create an instance of the Email class.</returns>
        public Email(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("Email", "Email cannot be null or empty");
                else if (!StringExtension.IsEmail(value))
                    AddNotification("Email", "Invalid email");
            }
            catch (Exception ex)
            {
                AddNotification("Email", $"Error: {ex.Message}");
            }
        }

        /// <summary>Return email address.</summary>
        public override string ToString() => Value;
    }
}
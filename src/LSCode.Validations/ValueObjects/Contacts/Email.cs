using LSCode.Notifiables.Notifications;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.ValueObjects.Contacts
{
    /// <summary>Assists in the use and validation of emails.</summary>
    public class Email : Notifiable
    {
        /// <value>Email address.</value>
        public string Value { get; private set; }

        /// <summary>Email class constructor.</summary>
        /// <remarks>Valid formats: Standard email format.</remarks>
        /// <param name="value">Email address.</param>
        /// <returns>Create an instance of the Email class.</returns>
        public Email(string value)
        {
            Value = value;

            if (string.IsNullOrWhiteSpace(Value))
                AddNotification("Email", "Email cannot be null, empty or white espaces");
            else if (!Value.IsEmail())
                AddNotification("Email", "Invalid email");
        }

        /// <summary>Return email address.</summary>
        public override string ToString() => Value;
    }
}
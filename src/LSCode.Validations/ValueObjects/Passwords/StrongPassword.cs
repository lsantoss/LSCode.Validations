using LSCode.Notifications.Models;
using LSCode.Validations.BooleanValidations.Extensions;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class StrongPassword : Notifiable
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>StrongPassword class constructor.</summary>
        /// <remarks>It must contain at least eight and at most fifteen characters; An uppercase letter; A lowercase letter; A number; a special character.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Create an instance of the StrongPassword class.</returns>
        public StrongPassword(string value)
        {
            Value = value;

            if (Value.IsNullOrEmptyOrWhiteSpace())
                AddNotification("Password", "Password cannot be null, empty or white spaces");

            else
            {
                if (Value.Length < 8)
                    AddNotification("Password", "Password must contain at least 8 characters");

                if (Value.Length > 15)
                    AddNotification("Password", "Password must contain a maximum of 15 characters");

                if (!Value.ContainsCapitalLetter())
                    AddNotification("Password", "Password must contain at least 1 capital letter");

                if (!Value.ContainsLowercaseLetter())
                    AddNotification("Password", "Password must contain at least 1 lowercase letter");

                if (!Value.ContainsNumber())
                    AddNotification("Password", "Password must contain at least 1 number");

                if (!Value.ContainsSpecialCharacter())
                    AddNotification("Password", "Password must contain at least 1 special character");
            }
        }

        /// <summary>Return password.</summary>
        public override string ToString() => Value;
    }
}
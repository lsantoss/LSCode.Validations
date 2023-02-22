using LSCode.Notifications.Models;
using LSCode.Validations.Extensions;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class AveragePassword : Notifiable
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the AveragePassword class.</summary>
        /// <remarks>It must contain at least six and at most fifteen characters; An uppercase letter; A lowercase letter; A number.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Create an instance of the AveragePassword class.</returns>
        public AveragePassword(string value)
        {
            Value = value;

            if (Value.IsNullOrEmptyOrWhiteSpace())
                AddNotification("Password", "Password cannot be null, empty or white spaces");

            else
            {
                if (Value.Length < 6)
                    AddNotification("Password", "Password must contain at least 6 characters");

                if (Value.Length > 15)
                    AddNotification("Password", "Password must contain a maximum of 15 characters");

                if (!Value.ContainsCapitalLetter())
                    AddNotification("Password", "Password must contain at least 1 capital letter");

                if (!Value.ContainsLowercaseLetter())
                    AddNotification("Password", "Password must contain at least 1 lowercase letter");

                if (!Value.ContainsNumber())
                    AddNotification("Password", "Password must contain at least 1 number");
            }
        }

        /// <summary>Return password.</summary>
        public override string ToString() => Value;
    }
}
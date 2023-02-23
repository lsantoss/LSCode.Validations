using LSCode.Notifications.Models;
using LSCode.Validations.BooleanValidations.Extensions;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class WeakPassword : Notifiable
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>WeakPassword class constructor.</summary>
        /// <remarks>It must contain at least six and at most fifteen characters; One letter; A number.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Creates an instance of the WeakPassword class.</returns>
        public WeakPassword(string value)
        {
            Value = value;

            if (Value.IsNullOrEmptyOrWhiteSpace())
                AddNotification("Password", "Password cannot be null, empty or white spaces");

            else
            {
                if (Value.Length < 6)
                    AddNotification("Password", "Password must contain at least 6 characters");

                if (Value.Length > 10)
                    AddNotification("Password", "Password must contain a maximum of 15 characters");

                if (!Value.ContainsLetter())
                    AddNotification("Password", "Password must contain at least 1 capital letter ou minúscula");

                if (!Value.ContainsNumber())
                    AddNotification("Password", "Password must contain at least 1 number");
            }                
        }

        /// <summary>Return password.</summary>
        public override string ToString() => Value;
    }
}
using LSCode.Notifiables.Notifications;

namespace LSCode.Validations.ValueObjects.Passwords
{
    /// <summary>Assists in the use and validation of passwords.</summary>
    public class VeryWeakPassword : Notifiable
    {
        /// <value>Password.</value>
        public string Value { get; private set; }

        /// <summary>VeryWeakPassword class constructor.</summary>
        /// <remarks>Must contain at least six and at most fifteen characters.</remarks>
        /// <param name="value">Password.</param>
        /// <returns>Creates an instance of the VeryWeakPassword class.</returns>
        public VeryWeakPassword(string value)
        {
            Value = value;

            if (string.IsNullOrWhiteSpace(Value))
                AddNotification("Password", "Password cannot be null, empty or white spaces");

            else
            {
                if (Value.Length < 6)
                    AddNotification("Password", "Password must contain at least 6 characters");

                if (Value.Length > 15)
                    AddNotification("Password", "Password must contain a maximum of 15 characters");
            }
        }

        /// <summary>Return password.</summary>
        public override string ToString() => Value;
    }
}
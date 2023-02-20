using LSCode.Notifiables.Notifications;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.ValueObjects.Technologies
{
    /// <summary>Assists in the use and validation of URL's.</summary>
    public class URL : Notifiable
    {
        /// <value>URL.</value>
        public string Value { get; private set; }

        /// <summary>URL class constructor.</summary>
        /// <param name="value">URL.</param>
        /// <returns>Create an instance of the URL class.</returns>
        public URL(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("URL", "URL cannot be null or empty");
                else if (!Value.IsUrl())
                    AddNotification("URL", "Invalid url");
            }
            catch (Exception ex)
            {
                AddNotification("URL", $"Error: {ex.Message}");
            }
        }

        /// <summary>Return the URL.</summary>
        public override string ToString() => Value;
    }
}
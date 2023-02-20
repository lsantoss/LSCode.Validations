using LSCode.Notifiables.Notifications;
using System;

namespace LSCode.Validations.ValueObjects.Texts
{
    /// <summary>Assists in the use and validation of abbreviations.</summary>
    public class Abbreviation : Notifiable
    {
        /// <value>Abbreviation.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the Abbreviation class.</summary>
        /// <remarks>Must contain a maximum of three characters.</remarks>
        /// <param name="value">Abbreviation.</param>
        /// <returns>Create an instance of the Abbreviation class.</returns>
        public Abbreviation(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("Abbreviation", "Abbreviation cannot be null or empty");

                else if (Value.Length > 3)
                    AddNotification("Abbreviation", "Abbreviation greater than 3 characters");
            }
            catch (Exception ex)
            {
                AddNotification("Abbreviation", $"Error: {ex.Message}");
            }
        }

        /// <summary>Returns the abbreviation.</summary>
        public override string ToString() => Value;
    }
}
using LSCode.Notifiables.Notifications;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.ValueObjects.Documents
{
    /// <summary>Assists in the use, validation and formatting of CPF numbers.</summary>
    public class CPF : Notifiable
    {
        /// <value>CPF number.</value>
        public string Value { get; private set; }

        /// <summary>CPF class constructor.</summary>
        /// <remarks>
        ///     Valid formats: CPF with or without mask. <br></br>
        ///     Output format: 000.000.000-00.
        /// </remarks>
        /// <param name="value">CPF number.</param>
        /// <returns>Create an instance of the CPF class.</returns>
        public CPF(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("CPF", "CPF cannot be null or empty");
                else if (!Value.IsCPF())
                    AddNotification("CPF", "Invalid CPF");
                else
                    Value = Format(value);
            }
            catch (Exception ex)
            {
                AddNotification("CPF", $"Error: {ex.Message}");
            }
        }

        /// <summary>Performs CPF number formatting.</summary>
        /// <param name="value">CPF number.</param>
        /// <returns>CPF number in format: 000.000.000-00.</returns>
        /// <exception cref="Exception">Error formatting CPF number.</exception>
        private string Format(string value)
        {
            if (value.Length == 14)
            {
                return value;
            }
            else
            {
                value = value.Trim();
                value = value.Replace(".", "").Replace("-", "").Replace("/", "");
                value = Convert.ToUInt64(value).ToString(@"000\.000\.000\-00");
                return value;
            }
        }

        /// <summary>Returns CPF number.</summary>
        public override string ToString() => Value;
    }
}
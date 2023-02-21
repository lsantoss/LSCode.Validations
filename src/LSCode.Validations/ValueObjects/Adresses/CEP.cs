using LSCode.Notifiables.Notifications;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.ValueObjects.Adresses
{
    /// <summary>Assists in the use, validation and formatting of CEP numbers.</summary>
    public class CEP : Notifiable
    {
        /// <value>CEP number.</value>
        public string Value { get; private set; }

        /// <summary>CEP class constructor.</summary>
        /// <remarks>
        ///     Valid formats: 37123-500 ou 37123500. <br></br>
        ///     Output format: 37123-500. <br></br>
        ///     Regex: ^\d{5}\-?\d{3}$
        /// </remarks>
        /// <param name="value">CEP number.</param>
        /// <returns>Creates an instance of the CEP class.</returns>
        public CEP(string value)
        {
            Value = value;

            if (string.IsNullOrWhiteSpace(Value))
                AddNotification("CEP", "CEP cannot be null, empty or white espaces");
            else if (!Value.IsCEP())
                AddNotification("CEP", "Invalid CEP");
            else
                Value = Format(value);
        }

        /// <summary>Format the CEP number.</summary>
        /// <param name="value">CEP number.</param>
        /// <returns>CEP in format: 37123-500.</returns>
        private string Format(string value) => value.Length == 9 ? value : Convert.ToUInt64(value).ToString(@"00000\-000");

        /// <summary>Returns CEP number.</summary>
        public override string ToString() => Value;
    }
}
using LSCode.Validations.Extensions;
using LSCode.Validations.Notifiable;
using System;

namespace LSCode.Validations.ValueObjects.Documents
{
    /// <summary>Assists in the use, validation and formatting of CNPJ numbers.</summary>
    public class CNPJ : Notifier
    {
        /// <value>CNPJ number.</value>
        public string Value { get; private set; }

        /// <summary>CNPJ class constructor.</summary>
        /// <remarks>
        ///     Valid formats: CNPJ with or without mask. <br></br>
        ///     Output format: 00.000.000/0000-00.
        /// </remarks>
        /// <param name="value">CNPJ number.</param>
        /// <returns>Create an instance of the CNPJ class.</returns>
        public CNPJ(string value)
        {
            try
            {
                Value = value;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("CNPJ", "CNPJ cannot be null or empty");
                else if (!StringExtension.IsCNPJ(value))
                    AddNotification("CNPJ", "Invalid CNPJ");
                else
                    Value = Format(value);
            }
            catch (Exception ex)
            {
                AddNotification("CNPJ", $"Error: {ex.Message}");
            }
        }

        /// <summary>Formats the CNPJ number.</summary>
        /// <param name="value">CNPJ number.</param>
        /// <returns>CNPJ number in format: 00.000.000/0000-00.</returns>
        /// <exception cref="Exception">Error formatting CNPJ number.</exception>
        private string Format(string value)
        {
            if (value.Length == 18)
            {
                return value;
            }
            else
            {
                value = value.Trim();
                value = value.Replace(".", "").Replace("-", "").Replace("/", "");
                value = Convert.ToUInt64(value).ToString(@"00\.000\.000\/0000\-00");
                return value;
            }
        }

        /// <summary>Returns CNPJ number.</summary>
        public override string ToString() => Value;
    }
}
using LSCode.Notifications.Models;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.ValueObjects.Contacts
{
    /// <summary>Assists in the use, validation and formatting of cellphone numbers.</summary>
    public class Cellphone : Notifiable
    {
        /// <value>Cellphone number.</value>
        public string Value { get; private set; }

        /// <summary>Cellphone class constructor.</summary>
        /// <remarks>
        ///     Valid formats: 32988887777 ou 3298888-7777 ou (32)988887777 ou (32)98888-7777. <br></br>
        ///     Output format: (32)98888-7777. <br></br>
        ///     Regex: ^(\(?)([0-9]{2})(\)?)[0-9]{5}-?[0-9]{4}$
        /// </remarks>
        /// <param name="value">Cellphone number.</param>
        /// <returns>Creates an instance of the Cellphone class.</returns>
        public Cellphone(string value)
        {
            Value = value;

            if (Value.IsNullOrEmptyOrWhiteSpace())
                AddNotification("Cellphone", "Cellphone cannot be null, empty or white espaces");
            else if (!Value.IsBrazilianCellphone())
                AddNotification("Cellphone", "Invalid cellphone");
            else
                Value = Format(value);
        }

        /// <summary>Format the cellphone number.</summary>
        /// <param name="value">Cellphone number.</param>
        /// <returns>Cellphone number in format: (32)98888-7777.</returns>
        private string Format(string value)
        {
            if (value.Length == 14)
            {
                return value;
            }
            else
            {
                value = value.Trim();
                value = value.Replace("(", "").Replace(")", "").Replace("-", "");
                value = Convert.ToUInt64(value).ToString(@"\(00\)00000\-0000");
                return value;
            }
        }

        /// <summary>Return cellphone number.</summary>
        public override string ToString() => Value;
    }
}
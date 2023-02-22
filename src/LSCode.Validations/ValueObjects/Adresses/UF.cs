using LSCode.Notifications.Models;
using LSCode.Validations.Extensions;

namespace LSCode.Validations.ValueObjects.Adresses
{
    /// <summary>Assists in the use and validation of UF.</summary>
    public class UF : Notifiable
    {
        /// <value>UF.</value>
        public string Value { get; private set; }

        /// <summary>UF class constructor.</summary>
        /// <remarks>
        ///     It must contain the initials of one of the Brazilian states. <br></br>
        ///     Valid formats: AC, AL, AM, AP, BA, CE, DF, ES, GO, MA, MG, MS, MT, PA, PB, PE, PI, PR, RJ, RN, RO, RR, RS, SC, SE, SP, TO
        /// </remarks>
        /// <param name="value">UF.</param>
        /// <returns>Create an instance of the UF class.</returns>
        public UF(string value)
        {
            Value = value;

            if (Value.IsNullOrEmptyOrWhiteSpace())
                AddNotification("UF", "UF cannot be null, empty or white espaces");
            else if (!Validar(Value))
                AddNotification("UF", "Invalid UF");
        }

        /// <summary>Performs validation of the UF.</summary>
        /// <param name="value">Must contain acronym of one of the Brazilian states.</param>
        /// <returns>True if valid or False if invalid.</returns>
        private bool Validar(string value)
        {
            Value = value.Trim().ToUpper();

            return Value == "RO" || Value == "AC" || Value == "AM" || Value == "RR" || Value == "PA" || Value == "AP" || Value == "TO" || Value == "MA" || Value == "PI" ||
                   Value == "CE" || Value == "RN" || Value == "PB" || Value == "PE" || Value == "AL" || Value == "SE" || Value == "BA" || Value == "MG" || Value == "ES" ||
                   Value == "RJ" || Value == "SP" || Value == "PR" || Value == "SC" || Value == "RS" || Value == "MS" || Value == "MT" || Value == "GO" || Value == "DF";
        }

        /// <summary>Returns the UF.</summary>
        public override string ToString() => Value;
    }
}
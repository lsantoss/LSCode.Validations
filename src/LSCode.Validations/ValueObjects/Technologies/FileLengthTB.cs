using LSCode.Validations.Notifiable;
using System;

namespace LSCode.Validations.ValueObjects.Technologies
{
    /// <summary>Assists in the use, validation and formatting of file length in TB.</summary>
    public class FileLengthTB : Notifier
    {
        /// <value>File length in TB.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the FileLengthTB class.</summary>
        /// <remarks>
        ///     Input formats: 1715238139330,56. <br></br>
        ///     Output format: 1,56 GB.
        /// </remarks>
        /// <param name="valueInBytes">File length in bytes (numbers only).</param>
        /// <returns>Creates an instance of the FileLengthTB class.</returns>
        public FileLengthTB(string valueInBytes)
        {
            try
            {
                Value = valueInBytes;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("FileLengthTB", "Content cannot be null or empty");
                else
                {
                    var tamanho = decimal.Parse(valueInBytes);

                    // Bytes to KBytes
                    tamanho /= 1024;

                    // KBytes to MBytes
                    tamanho /= 1024;

                    // MBytes to GBytes
                    tamanho /= 1024;

                    // GBytes to TBytes
                    tamanho /= 1024;

                    Value = $"{tamanho:N2} TB";
                }
            }
            catch (Exception ex)
            {
                AddNotification("FileLengthTB", $"Error: {ex.Message}");
            }
        }

        /// <summary>Returns the file size in TeraBytes.</summary>
        public override string ToString() => Value;
    }
}
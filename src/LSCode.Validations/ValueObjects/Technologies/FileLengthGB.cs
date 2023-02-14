using LSCode.Validations.Notifiable;
using System;

namespace LSCode.Validations.ValueObjects.Technologies
{
    /// <summary>Assists in the use, validation and formatting of file length in GB.</summary>
    public class FileLengthGB : Notifier
    {
        /// <value>File length in GB.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the FileLengthGB class.</summary>
        /// <remarks>
        ///     Input formats: 1675037245,44. <br></br>
        ///     Output format: 1,56 GB.
        /// </remarks>
        /// <param name="valueInBytes">File length in bytes (numbers only).</param>
        /// <returns>Creates an instance of the FileLengthGB class.</returns>
        public FileLengthGB(string valueInBytes)
        {
            try
            {
                Value = valueInBytes;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("FileLengthGB", "Content cannot be null or empty");
                else
                {
                    var tamanho = decimal.Parse(Value);

                    // Bytes to KBytes
                    tamanho /= 1024;

                    // KBytes to MBytes
                    tamanho /= 1024;

                    // MBytes to GBytes
                    tamanho /= 1024;

                    Value = $"{tamanho:N2} GB";
                }
            }
            catch (Exception ex)
            {
                AddNotification("FileLengthGB", $"Error: {ex.Message}");
            }
        }

        /// <summary>Returns the file size in GigaBytes.</summary>
        public override string ToString() => Value;
    }
}
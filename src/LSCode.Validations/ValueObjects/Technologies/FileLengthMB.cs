using LSCode.Validations.Notifiable;
using System;

namespace LSCode.Validations.ValueObjects.Technologies
{
    /// <summary>Assists in the use, validation and formatting of file length in MB.</summary>
    public class FileLengthMB : Notifier
    {
        /// <value>File length in MB.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the FileLengthMB class.</summary>
        /// <remarks>
        ///     Input formats: 1635778,56. <br></br>
        ///     Output format: 1,56 GB.
        /// </remarks>
        /// <param name="valueInBytes">File length in bytes (numbers only).</param>
        /// <returns>Create an instance of the FileLengthMB class.</returns>
        public FileLengthMB(string valueInBytes)
        {
            try
            {
                Value = valueInBytes;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("FileLengthMB", "Content cannot be null or empty");
                else
                {
                    var tamanho = decimal.Parse(valueInBytes);

                    // Bytes to KBytes
                    tamanho /= 1024;

                    // KBytes to MBytes
                    tamanho /= 1024;

                    Value = $"{tamanho:N2} MB";
                }
            }
            catch (Exception ex)
            {
                AddNotification("FileLengthMB", $"Error: {ex.Message}");
            }
        }

        /// <summary>Returns the file length in MegaBytes.</summary>
        public override string ToString() => Value;
    }
}
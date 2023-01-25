using LSCode.Validations.NotifiableValidations;
using System;

namespace LSCode.Validations.ValueObjects.Technologies
{
    /// <summary>Assists in the use, validation and formatting of file length in KB.</summary>
    public class FileLengthKB : Notifier
    {
        /// <value>File length in KB.</value>
        public string Value { get; private set; }

        /// <summary>Constructor of the FileLengthKB class.</summary>
        /// <remarks>
        ///     Input formats: 1597,44. <br></br>
        ///     Output format: 1,56 GB.
        /// </remarks>
        /// <param name="valueInBytes">File length in bytes (numbers only).</param>
        /// <returns>Create an instance of the FileLengthKB class.</returns>
        public FileLengthKB(string valueInBytes)
        {
            try
            {
                Value = valueInBytes;

                if (string.IsNullOrWhiteSpace(Value))
                    AddNotification("FileLengthKB", "Content cannot be null or empty");
                else
                {
                    var length = decimal.Parse(valueInBytes);

                    // Bytes to KBytes
                    length /= 1024;

                    Value = $"{length:N2} KB";
                }
            }
            catch (Exception ex)
            {
                AddNotification("FileLengthKB", $"Error: {ex.Message}");
            }
        }

        /// <summary>Returns the file length in KiloBytes.</summary>
        public override string ToString() => Value;
    }
}
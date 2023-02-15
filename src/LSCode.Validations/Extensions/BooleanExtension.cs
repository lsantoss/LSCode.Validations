namespace LSCode.Validations.Extensions
{
    /// <summary>Fornece métodos de extensão que contêm validações entre dados booleanos com retornos booleanos.</summary>
    public static class BooleanExtension
    {
        /// <summary>Validates if value is false.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if false or False if true.</returns>
        public static bool IsFalse(this bool value) => value == false;

        /// <summary>Validates if value is true.</summary>
        /// <param name="value">Value to be compared.</param>
        /// <returns>True if true or False if false.</returns>
        public static bool IsTrue(this bool value) => value == true;
    }
}
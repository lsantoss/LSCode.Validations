using System.Text.RegularExpressions;

namespace LSCode.Validations.RegexValidations
{
    /// <summary>Provides methods to facilitate string validation using Regex.</summary>
    public static class RegexValidation
    {
        /// <summary>Indicates whether the specified regular expression finds a match in the specified input string.</summary>
        /// <remarks>Already has null, empty, or whitespace string validation.</remarks>
        /// <param name="value">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>True if the regular expression finds a match. Otherwise, false.</returns>
        public static bool IsMatch(string value, string pattern) => Regex.IsMatch(value ?? "", pattern);
    }
}
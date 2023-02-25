using System.Text.RegularExpressions;

namespace LSCode.Validations.RegexValidations
{
    public static class RegexValidation
    {
        public static bool IsMatch(string value, string regex) => !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, regex);
    }
}
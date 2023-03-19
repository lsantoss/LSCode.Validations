using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Constants
{
    /// <summary>Provides all Regex patterns present in this package.</summary>
    internal static class RegexPatterns
    {
        /// <summary>Brazilian cellphone pattern.</summary>
        public static string BrazilianCellphone { get; } = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])9[1-9][0-9]{7}$";

        /// <summary>Passport pattern.</summary>
        public static string BrazilianPassport { get; } = @"^[A-Z]{2}[0-9]{6}$";

        /// <summary>Brazilian telephone pattern.</summary>
        public static string BrazilianTelephone { get; } = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])[2-8][0-9]{7}$";

        /// <summary>CEP pattern.</summary>
        public static string CEP { get; } = @"^[0-9]{5}-?[0-9]{3}$";

        /// <summary>Contains capital letter pattern.</summary>
        public static string ContainsCapitalLetter { get; } = "[A-Z]+";

        /// <summary>Contains letter pattern.</summary>
        public static string ContainsLetter { get; } = "[a-z]+|[A-Z]+";

        /// <summary>Contains lowercase letter pattern.</summary>
        public static string ContainsLowercaseLetter { get; } = "[a-z]+";

        /// <summary>Contains number pattern.</summary>
        public static string ContainsNumber { get; } = "[0-9]+";

        /// <summary>Contains only capital letters pattern.</summary>
        public static string ContainsOnlyCapitalLetters { get; } = "^[A-Z]+$";

        /// <summary>Contains only letters pattern.</summary>
        public static string ContainsOnlyLetters { get; } = "^[a-zA-Z]+$";

        /// <summary>Contains only lowercase letters pattern.</summary>
        public static string ContainsOnlyLowercaseLetters { get; } = "^[a-z]+$";

        /// <summary>Contains only numbers letters pattern.</summary>
        public static string ContainsOnlyNumbers { get; } = "^[0-9]+$";

        /// <summary>Contains only special characters pattern.</summary>
        public static string ContainsOnlySpecialCharacters { get; } = @"^[!@#$%^&*()_+=\[{\]};:<>|./?,-]+$";

        /// <summary>Contains special characters pattern.</summary>
        public static string ContainsSpecialCharacter { get; } = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+";

        /// <summary>Email pattern.</summary>
        public static string Email { get; } = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        /// <summary>Except numbers pattern.</summary>
        public static string ExceptNumbers { get; } = "[^0-9]+";
    }
}
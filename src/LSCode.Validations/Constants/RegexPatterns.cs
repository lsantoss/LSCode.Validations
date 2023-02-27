using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Constants
{
    /// <summary>Provides all Regex patterns present in this package.</summary>
    internal static class RegexPatterns
    {
        /// <summary>Brazilian cellphone pattern.</summary>
        public const string BrazilianCellphone = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])9[1-9][0-9]{7}$";

        /// <summary>Brazilian telephone pattern.</summary>
        public const string BrazilianTelephone = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])[2-8][0-9]{7}$";

        /// <summary>CEP pattern.</summary>
        public const string CEP = @"^\d{5}\-?\d{3}$";

        /// <summary>Contains capital letter pattern.</summary>
        public const string ContainsCapitalLetter = "[A-Z]+";

        /// <summary>Contains letter pattern.</summary>
        public const string ContainsLetter = "[a-z]+|[A-Z]+";

        /// <summary>Contains lowercase letter pattern.</summary>
        public const string ContainsLowercaseLetter = "[a-z]+";

        /// <summary>Contains number pattern.</summary>
        public const string ContainsNumber = "[0-9]+";

        /// <summary>Contains only capital letters pattern.</summary>
        public const string ContainsOnlyCapitalLetters = "^[A-Z]+$";

        /// <summary>Contains only letters pattern.</summary>
        public const string ContainsOnlyLetters = "^[a-zA-Z]+$";

        /// <summary>Contains only lowercase letters pattern.</summary>
        public const string ContainsOnlyLowercaseLetters = "^[a-z]+$";

        /// <summary>Contains only numbers letters pattern.</summary>
        public const string ContainsOnlyNumbers = "^[0-9]+$";

        /// <summary>Contains only special characters pattern.</summary>
        public const string ContainsOnlySpecialCharacters = @"^[!@#$%^&*()_+=\[{\]};:<>|./?,-]+$";

        /// <summary>Contains special characters pattern.</summary>
        public const string ContainsSpecialCharacter = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+";

        /// <summary>Email pattern.</summary>
        public const string Email = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        /// <summary>Except numbers pattern.</summary>
        public const string ExceptNumbers = "[^0-9]+";

        /// <summary>Passport pattern.</summary>
        public const string Passport = "^(?!^0+$)[a-zA-Z0-9]{3,20}$";
    }
}
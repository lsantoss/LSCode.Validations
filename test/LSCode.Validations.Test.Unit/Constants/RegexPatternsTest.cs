﻿using LSCode.Validations.Constants;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.Constants
{
    [TestFixture]
    internal class RegexPatternsTest
    {
        [Test]
        public void BrazilianCellphone_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.BrazilianCellphone;
            var expected = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])9[1-9][0-9]{7}$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void BrazilianPassport_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.BrazilianPassport;
            var expected = @"^[A-Z]{2}[0-9]{6}$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void BrazilianTelephone_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.BrazilianTelephone;
            var expected = "^55(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])[2-8][0-9]{7}$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void CEP_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.CEP;
            var expected = @"^[0-9]{5}-?[0-9]{3}$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsCapitalLetter_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsCapitalLetter;
            var expected = "[A-Z]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsLetter_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsLetter;
            var expected = "[a-z]+|[A-Z]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsLowercaseLetter_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsLowercaseLetter;
            var expected = "[a-z]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsNumber_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsNumber;
            var expected = "[0-9]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsOnlyCapitalLetters_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsOnlyCapitalLetters;
            var expected = "^[A-Z]+$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsOnlyLetters_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsOnlyLetters;
            var expected = "^[a-zA-Z]+$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsOnlyLowercaseLetters_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsOnlyLowercaseLetters;
            var expected = "^[a-z]+$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsOnlyNumbers_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsOnlyNumbers;
            var expected = "^[0-9]+$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsOnlySpecialCharacters_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsOnlySpecialCharacters;
            var expected = @"^[!@#$%^&*()_+=\[{\]};:<>|./?,-]+$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsSpecialCharacter_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ContainsSpecialCharacter;
            var expected = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void Email_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.Email;
            var expected = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }

        [Test]
        public void ExceptNumbers_Pattern_Valid()
        {
            //Arrange
            var value = RegexPatterns.ExceptNumbers;
            var expected = "[^0-9]+";

            //Assert
            Assert.That(value, Is.EqualTo(expected));
        }
    }
}
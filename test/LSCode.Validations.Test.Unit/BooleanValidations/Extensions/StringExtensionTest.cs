﻿using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class StringExtensionTest
    {
        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("House")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsCapitalLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsCapitalLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555 e")]
        [TestCase("$#%& e")]
        [TestCase("5555$#%&e")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsCapitalLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsCapitalLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("tests")]
        [TestCase("tests55")]
        [TestCase("tests 55")]
        [TestCase("House 55 **")]
        public void ContainsLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555")]
        [TestCase("$#%&")]
        [TestCase("5555$#%&")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("House")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsLowercaseLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsLowercaseLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555 E")]
        [TestCase("$#%& E")]
        [TestCase("5555$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsLowercaseLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsLowercaseLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("5")]
        [TestCase("5 5")]
        [TestCase("5 5 5")]
        [TestCase("Text cannot be null or empty 5")]
        [TestCase("House5")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsNumber_True_Success(string value)
        {
            //Act
            var result = value.ContainsNumber();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("aaaa E")]
        [TestCase("$#%& E")]
        [TestCase("aaaa$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsNumber_False_Success(string value)
        {
            //Act
            var result = value.ContainsNumber();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("A")]
        [TestCase("AA")]
        [TestCase("AAA")]
        [TestCase("AAAA")]
        public void ContainsOnlyCapitalLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyCapitalLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aA")]
        [TestCase("5555")]
        [TestCase("aa555##")]
        [TestCase("AA555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyCapitalLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyCapitalLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("a")]
        [TestCase("A")]
        [TestCase("aAaA")]
        [TestCase("AAaAaaA")]
        public void ContainsOnlyLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5")]
        [TestCase("55 ##")]
        [TestCase("555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aaa")]
        [TestCase("aaaa")]
        public void ContainsOnlyLowercaseLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLowercaseLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("A")]
        [TestCase("aA")]
        [TestCase("5555")]
        [TestCase("aa555##")]
        [TestCase("AA555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyLowercaseLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLowercaseLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("5")]
        [TestCase("55")]
        [TestCase("555")]
        [TestCase("5555")]
        public void ContainsOnlyNumbers_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyNumbers();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("4 ")]
        [TestCase("4 4")]
        [TestCase("4 4 4")]
        [TestCase("4 E")]
        [TestCase("aaaa E")]
        [TestCase("aaaa55E")]
        [TestCase("$#%& E5")]
        [TestCase("5aaaa$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyNumbers_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyNumbers();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("&&")]
        [TestCase("$#%&")]
        [TestCase("!!!$#%&%&")]
        public void ContainsOnlySpecialCharacters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlySpecialCharacters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("#$ ")]
        [TestCase("#$ ##")]
        [TestCase("#$ 55")]
        [TestCase("Text cannot be null #")]
        [TestCase("House5#")]
        [TestCase("houSe55$%$@@")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlySpecialCharacters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlySpecialCharacters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("5555 aa e &&")]
        [TestCase("$#%& e")]
        [TestCase("5555$#%&e")]
        [TestCase("tests 5555 $#%& e")]
        public void ContainsSpecialCharacter_True_Success(string value)
        {
            //Act
            var result = value.ContainsSpecialCharacter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty 5")]
        [TestCase("House5")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsSpecialCharacter_False_Success(string value)
        {
            //Act
            var result = value.ContainsSpecialCharacter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", "Text")]
        [TestCase("Text cannot be null or empty", "cannot")]
        [TestCase("Text cannot be null or empty", "be")]
        [TestCase("Text cannot be null or empty", "null")]
        [TestCase("Text cannot be null or empty", "or")]
        [TestCase("Text cannot be null or empty", "empty")]
        [TestCase("Text cannot be null or empty", "can")]
        [TestCase("Text cannot be null or empty", " ")]
        public void ContainsText_True_Success(string value, string text)
        {
            //Act
            var result = value.ContainsText(text);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", "tests")]
        [TestCase("Text cannot be null or empty", "home")]
        [TestCase("Text cannot be null or empty", "site")]
        [TestCase("Text cannot be null or empty", "car")]
        [TestCase("Text cannot be null or empty", "")]
        [TestCase("Text cannot be null or empty", null)]
        [TestCase(null, "tests")]
        [TestCase(null, null)]
        public void ContainsText_False_Success(string value, string text)
        {
            //Act
            var result = value.ContainsText(text);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 12)]
        [TestCase("tests", 10)]
        public void HasDifferentLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasDifferentLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 5)]
        [TestCase(null, 10)]
        public void HasDifferentLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasDifferentLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 5)]
        public void HasEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 12)]
        [TestCase("tests", 10)]
        [TestCase(null, 10)]
        public void HasEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasGreaterLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasGreaterLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 4)]
        [TestCase("tests", 5)]
        public void HasGreaterOrEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasGreaterOrEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 6)]
        public void HasSmallerLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 4)]
        [TestCase("tests", 5)]
        [TestCase(null, 10)]
        public void HasSmallerLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        public void HasSmallerOrEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        [TestCase(null, 10)]
        public void HasSmallerOrEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }
            
        [Test]
        public void IsNull_True_Success()
        {
            //Arrange
            string value1 = null;
            int? value2 = null;

            //Act
            var result1 = value1.IsNull();
            var result2 = value2.IsNull();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.True);
                Assert.That(result2, Is.True);
            });
        }

        [Test]
        public void IsNull_False_Success()
        {
            //Arrange
            var value1 = false;
            var value2 = 1;
            var value3 = "tests";
            var value4 = new { reason = "tests" };

            //Act
            var result1 = value1.IsNull();
            var result2 = value2.IsNull();
            var result3 = value3.IsNull();
            var result4 = value4.IsNull();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.False);
                Assert.That(result2, Is.False);
                Assert.That(result3, Is.False);
                Assert.That(result4, Is.False);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void IsNullOrEmpty_True_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase(" ")]
        public void IsNullOrEmpty_False_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void IsNullOrEmptyOrWhiteSpace_True_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmptyOrWhiteSpace();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("tests")]
        public void IsNullOrEmptyOrWhiteSpace_False_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmptyOrWhiteSpace();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("http://wwww.google.com.br")]
        [TestCase("https://wwww.google.com.br")]
        public void IsUrl_True_Success(string value)
        {
            //Act
            var result = value.IsUrl();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Test if it's a url")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsUrl_False_Success(string value)
        {
            //Act
            var result = value.IsUrl();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
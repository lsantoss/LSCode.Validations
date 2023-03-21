using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsEmptyExtensionTest
    {
        [Test]
        [TestCase(' ')]
        public void IsEmpty_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        [TestCase('1')]
        [TestCase('$')]
        public void IsEmpty_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("")]
        public void IsEmpty_string_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("aaa")]
        [TestCase("aaa aaa")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsEmpty_string_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEmpty_Guid_ShouldReturnTrue()
        {
            //Arrange
            var value = Guid.Empty;

            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("2f3d1a60-b870-4375-8874-2b8fe359518e")]
        [TestCase("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534")]
        [TestCase("837c4bff-3ade-419b-b815-13568d40ddab")]
        public void IsEmpty_Guid_ShouldReturnFalse(string value)
        {
            //Arrange
            var valueParsed = Guid.Parse(value);

            //Act
            var result = valueParsed.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
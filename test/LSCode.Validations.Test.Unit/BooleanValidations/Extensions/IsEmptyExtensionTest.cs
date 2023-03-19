using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsEmptyExtensionTest
    {
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
        public void IsEmpty_Guid_ShouldReturnFalse()
        {
            //Arrange
            var value = Guid.NewGuid();

            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
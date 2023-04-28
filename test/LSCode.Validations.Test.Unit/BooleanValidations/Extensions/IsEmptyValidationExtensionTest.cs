using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsEmptyValidationExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsEmptyValidationExtensionTest
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
        [TestCaseSource(typeof(IsEmptyValidationExtensionMockData), nameof(IsEmpty_Guid_ShouldReturnTrue_Data))]
        public void IsEmpty_Guid_ShouldReturnTrue(Guid value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsEmptyValidationExtensionMockData), nameof(IsEmpty_Guid_ShouldReturnFalse_Data))]
        public void IsEmpty_Guid_ShouldReturnFalse(Guid value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsEmptyValidationExtensionMockData), nameof(IsEmpty_IEnumerable_ShouldReturnTrue_Data))]
        public void IsEmpty_IEnumerable_ShouldReturnTrue(IEnumerable<int> value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        [TestCaseSource(typeof(IsEmptyValidationExtensionMockData), nameof(IsEmpty_IEnumerable_ShouldReturnFalse_Data))]
        public void IsEmpty_IEnumerable_ShouldReturnFalse(IEnumerable<int> value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
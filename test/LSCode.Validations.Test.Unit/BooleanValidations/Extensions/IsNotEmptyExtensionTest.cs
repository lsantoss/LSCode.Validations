using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsNotEmptyExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotEmptyExtensionTest
    {
        [Test]
        [TestCase('a')]
        [TestCase('b')]
        [TestCase('1')]
        [TestCase('$')]
        public void IsNotEmpty_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(' ')]
        public void IsNotEmpty_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("aaa")]
        [TestCase("aaa aaa")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsNotEmpty_string_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("")]
        public void IsNotEmpty_string_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEmptyExtensionMockData), nameof(IsNotEmpty_Guid_ShouldReturnTrue_Data))]
        public void IsNotEmpty_Guid_ShouldReturnTrue(Guid value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEmptyExtensionMockData), nameof(IsNotEmpty_Guid_ShouldReturnFalse_Data))]
        public void IsNotEmpty_Guid_ShouldReturnFalse(Guid value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        [TestCaseSource(typeof(IsNotEmptyExtensionMockData), nameof(IsNotEmpty_IEnumerable_ShouldReturnTrue_Data))]
        public void IsNotEmpty_IEnumerable_ShouldReturnTrue(IEnumerable<int> value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEmptyExtensionMockData), nameof(IsNotEmpty_IEnumerable_ShouldReturnFalse_Data))]
        public void IsNotEmpty_IEnumerable_ShouldReturnFalse(IEnumerable<int> value)
        {
            //Act
            var result = value.IsNotEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
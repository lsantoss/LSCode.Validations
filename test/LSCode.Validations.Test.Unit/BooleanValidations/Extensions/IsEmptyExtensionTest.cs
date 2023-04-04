﻿using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsEmptyExtensionMockData;

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
        [TestCaseSource(typeof(IsEmptyExtensionMockData), nameof(IsEmpty_Guid_ShouldReturnTrue_Data))]
        public void IsEmpty_Guid_ShouldReturnTrue(Guid value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsEmptyExtensionMockData), nameof(IsEmpty_Guid_ShouldReturnFalse_Data))]
        public void IsEmpty_Guid_ShouldReturnFalse(Guid value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
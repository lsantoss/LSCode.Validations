﻿using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.HasLengthGreaterThanValidationExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class HasLengthGreaterThanValidationExtensionTest
    {
        #region ## Region for main value with type string ##

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasLengthGreaterThan_string_sbyte_ShouldReturnTrue(string value, sbyte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasLengthGreaterThan_string_sbyte_ShouldReturnFalse(string value, sbyte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasLengthGreaterThan_string_byte_ShouldReturnTrue(string value, byte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasLengthGreaterThan_string_byte_ShouldReturnFalse(string value, byte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasLengthGreaterThan_string_short_ShouldReturnTrue(string value, short length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasLengthGreaterThan_string_short_ShouldReturnFalse(string value, short length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (ushort)27)]
        [TestCase("tests", (ushort)4)]
        public void HasLengthGreaterThan_string_ushort_ShouldReturnTrue(string value, ushort length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (ushort)28)]
        [TestCase("Text cannot be null or empty", (ushort)29)]
        [TestCase("tests", (ushort)5)]
        [TestCase("tests", (ushort)6)]
        [TestCase(null, (ushort)10)]
        public void HasLengthGreaterThan_string_ushort_ShouldReturnFalse(string value, ushort length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasLengthGreaterThan_string_int_ShouldReturnTrue(string value, int length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasLengthGreaterThan_string_int_ShouldReturnFalse(string value, int length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (uint)27)]
        [TestCase("tests", (uint)4)]
        public void HasLengthGreaterThan_string_uint_ShouldReturnTrue(string value, uint length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (uint)28)]
        [TestCase("Text cannot be null or empty", (uint)29)]
        [TestCase("tests", (uint)5)]
        [TestCase("tests", (uint)6)]
        [TestCase(null, (uint)10)]
        public void HasLengthGreaterThan_string_uint_ShouldReturnFalse(string value, uint length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasLengthGreaterThan_string_long_ShouldReturnTrue(string value, long length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasLengthGreaterThan_string_long_ShouldReturnFalse(string value, long length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (ulong)27)]
        [TestCase("tests", (ulong)4)]
        public void HasLengthGreaterThan_string_ulong_ShouldReturnTrue(string value, ulong length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", (ulong)28)]
        [TestCase("Text cannot be null or empty", (ulong)29)]
        [TestCase("tests", (ulong)5)]
        [TestCase("tests", (ulong)6)]
        [TestCase(null, (ulong)10)]
        public void HasLengthGreaterThan_string_ulong_ShouldReturnFalse(string value, ulong length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type IEnumerable ##

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_sbyte_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_sbyte_ShouldReturnTrue(IEnumerable<int> value, sbyte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase(null, 1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_sbyte_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_sbyte_ShouldReturnFalse(IEnumerable<int> value, sbyte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_byte_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_byte_ShouldReturnTrue(IEnumerable<int> value, byte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase(null, 1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_byte_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_byte_ShouldReturnFalse(IEnumerable<int> value, byte length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_short_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_short_ShouldReturnTrue(IEnumerable<int> value, short length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase(null, 1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_short_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_short_ShouldReturnFalse(IEnumerable<int> value, short length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_ushort_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_ushort_ShouldReturnTrue(IEnumerable<int> value, ushort length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, (ushort)0)]
        [TestCase(null, (ushort)1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_ushort_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_ushort_ShouldReturnFalse(IEnumerable<int> value, ushort length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_int_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_int_ShouldReturnTrue(IEnumerable<int> value, int length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase(null, 1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_int_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_int_ShouldReturnFalse(IEnumerable<int> value, int length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_uint_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_uint_ShouldReturnTrue(IEnumerable<int> value, uint length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, (uint)0)]
        [TestCase(null, (uint)1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_uint_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_uint_ShouldReturnFalse(IEnumerable<int> value, uint length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_long_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_long_ShouldReturnTrue(IEnumerable<int> value, long length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase(null, 1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_long_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_long_ShouldReturnFalse(IEnumerable<int> value, long length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_ulong_ShouldReturnTrue_Data))]
        public void HasLengthGreaterThan_IEnumerable_ulong_ShouldReturnTrue(IEnumerable<int> value, ulong length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, (ulong)0)]
        [TestCase(null, (ulong)1)]
        [TestCaseSource(typeof(HasLengthGreaterThanValidationExtensionMockData), nameof(HasLengthGreaterThan_IEnumerable_ulong_ShouldReturnFalse_Data))]
        public void HasLengthGreaterThan_IEnumerable_ulong_ShouldReturnFalse(IEnumerable<int> value, ulong length)
        {
            //Act
            var result = value.HasLengthGreaterThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion
    }
}
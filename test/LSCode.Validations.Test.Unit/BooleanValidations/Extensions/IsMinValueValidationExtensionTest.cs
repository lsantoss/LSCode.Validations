using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsMinValueValidationExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsMinValueValidationExtensionTest
    {
        [Test]
        [TestCase(sbyte.MinValue)]
        public void IsMinValue_sbyte_ShouldReturnTrue(sbyte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(sbyte.MaxValue)]
        public void IsMinValue_sbyte_ShouldReturnFalse(sbyte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(byte.MinValue)]
        public void IsMinValue_byte_ShouldReturnTrue(byte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MaxValue)]
        public void IsMinValue_byte_ShouldReturnFalse(byte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(short.MinValue)]
        public void IsMinValue_short_ShouldReturnTrue(short value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(short.MaxValue)]
        public void IsMinValue_short_ShouldReturnFalse(short value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ushort.MinValue)]
        public void IsMinValue_ushort_ShouldReturnTrue(ushort value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MaxValue)]
        public void IsMinValue_ushort_ShouldReturnFalse(ushort value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(int.MinValue)]
        public void IsMinValue_int_ShouldReturnTrue(int value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MaxValue)]
        public void IsMinValue_int_ShouldReturnFalse(int value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(uint.MinValue)]
        public void IsMinValue_uint_ShouldReturnTrue(uint value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MaxValue)]
        public void IsMinValue_uint_ShouldReturnFalse(uint value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(long.MinValue)]
        public void IsMinValue_long_ShouldReturnTrue(long value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(long.MaxValue)]
        public void IsMinValue_long_ShouldReturnFalse(long value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ulong.MinValue)]
        public void IsMinValue_ulong_ShouldReturnTrue(ulong value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MaxValue)]
        public void IsMinValue_ulong_ShouldReturnFalse(ulong value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(float.MinValue)]
        public void IsMinValue_float_ShouldReturnTrue(float value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        [TestCase(float.MaxValue)]
        public void IsMinValue_float_ShouldReturnFalse(float value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(double.MinValue)]
        public void IsMinValue_double_ShouldReturnTrue(double value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        [TestCase(double.MaxValue)]
        public void IsMinValue_double_ShouldReturnFalse(double value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMinValueValidationExtensionMockData), nameof(IsMinValue_decimal_ShouldReturnTrue_Data))]
        public void IsMinValue_decimal_ShouldReturnTrue(decimal value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsMinValue_decimal_ShouldReturnFalse(decimal value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(char.MinValue)]
        public void IsMinValue_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        public void IsMinValue_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMinValueValidationExtensionMockData), nameof(IsMinValue_Datetime_ShouldReturnTrue_Data))]
        public void IsMinValue_DateTime_ShouldReturnTrue(DateTime value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsMinValueValidationExtensionMockData), nameof(IsMinValue_Datetime_ShouldReturnFalse_Data))]
        public void IsMinValue_DateTime_ShouldReturnFalse(DateTime value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMinValueValidationExtensionMockData), nameof(IsMinValue_TimeSpan_ShouldReturnTrue_Data))]
        public void IsMinValue_TimeSpan_ShouldReturnTrue(TimeSpan value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsMinValueValidationExtensionMockData), nameof(IsMinValue_TimeSpan_ShouldReturnFalse_Data))]
        public void IsMinValue_TimeSpan_ShouldReturnFalse(TimeSpan value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
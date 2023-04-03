using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsMaxValueExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsMaxValueExtensionTest
    {
        [Test]
        [TestCase(sbyte.MaxValue)]
        public void IsMaxValue_sbyte_ShouldReturnTrue(sbyte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(sbyte.MinValue)]
        public void IsMaxValue_sbyte_ShouldReturnFalse(sbyte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(byte.MaxValue)]
        public void IsMaxValue_byte_ShouldReturnTrue(byte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MinValue)]
        public void IsMaxValue_byte_ShouldReturnFalse(byte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(short.MaxValue)]
        public void IsMaxValue_short_ShouldReturnTrue(short value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(short.MinValue)]
        public void IsMaxValue_short_ShouldReturnFalse(short value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ushort.MaxValue)]
        public void IsMaxValue_ushort_ShouldReturnTrue(ushort value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MinValue)]
        public void IsMaxValue_ushort_ShouldReturnFalse(ushort value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(int.MaxValue)]
        public void IsMaxValue_int_ShouldReturnTrue(int value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MinValue)]
        public void IsMaxValue_int_ShouldReturnFalse(int value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(uint.MaxValue)]
        public void IsMaxValue_uint_ShouldReturnTrue(uint value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MinValue)]
        public void IsMaxValue_uint_ShouldReturnFalse(uint value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(long.MaxValue)]
        public void IsMaxValue_long_ShouldReturnTrue(long value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(long.MinValue)]
        public void IsMaxValue_long_ShouldReturnFalse(long value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ulong.MaxValue)]
        public void IsMaxValue_ulong_ShouldReturnTrue(ulong value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MinValue)]
        public void IsMaxValue_ulong_ShouldReturnFalse(ulong value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(float.MaxValue)]
        public void IsMaxValue_float_ShouldReturnTrue(float value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        [TestCase(float.MinValue)]
        public void IsMaxValue_float_ShouldReturnFalse(float value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(double.MaxValue)]
        public void IsMaxValue_double_ShouldReturnTrue(double value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        [TestCase(double.MinValue)]
        public void IsMaxValue_double_ShouldReturnFalse(double value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_decimal_ShouldReturnTrue_Data))]
        public void IsMaxValue_decimal_ShouldReturnTrue(decimal value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsMaxValue_decimal_ShouldReturnFalse(decimal value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_char_ShouldReturnTrue_Data))]
        public void IsMaxValue_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        [TestCase(char.MinValue)]
        public void IsMaxValue_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_Datetime_ShouldReturnTrue_Data))]
        public void IsMaxValue_DateTime_ShouldReturnTrue(DateTime value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_Datetime_ShouldReturnFalse_Data))]
        public void IsMaxValue_DateTime_ShouldReturnFalse(DateTime value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_TimeSpan_ShouldReturnTrue_Data))]
        public void IsMaxValue_TimeSpan_ShouldReturnTrue(TimeSpan value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsMaxValueExtensionMockData), nameof(IsMaxValue_TimeSpan_ShouldReturnFalse_Data))]
        public void IsMaxValue_TimeSpan_ShouldReturnFalse(TimeSpan value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
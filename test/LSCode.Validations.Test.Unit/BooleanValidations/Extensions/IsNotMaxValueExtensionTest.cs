using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsNotMaxValueExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotMaxValueExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(sbyte.MinValue)]
        public void IsNotMaxValue_sbyte_ShouldReturnTrue(sbyte value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(sbyte.MaxValue)]
        public void IsNotMaxValue_sbyte_ShouldReturnFalse(sbyte value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MinValue)]
        public void IsNotMaxValue_byte_ShouldReturnTrue(byte value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(byte.MaxValue)]
        public void IsNotMaxValue_byte_ShouldReturnFalse(byte value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(short.MinValue)]
        public void IsNotMaxValue_short_ShouldReturnTrue(short value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(short.MaxValue)]
        public void IsNotMaxValue_short_ShouldReturnFalse(short value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MinValue)]
        public void IsNotMaxValue_ushort_ShouldReturnTrue(ushort value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ushort.MaxValue)]
        public void IsNotMaxValue_ushort_ShouldReturnFalse(ushort value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MinValue)]
        public void IsNotMaxValue_int_ShouldReturnTrue(int value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(int.MaxValue)]
        public void IsNotMaxValue_int_ShouldReturnFalse(int value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MinValue)]
        public void IsNotMaxValue_uint_ShouldReturnTrue(uint value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(uint.MaxValue)]
        public void IsNotMaxValue_uint_ShouldReturnFalse(uint value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(long.MinValue)]
        public void IsNotMaxValue_long_ShouldReturnTrue(long value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(long.MaxValue)]
        public void IsNotMaxValue_long_ShouldReturnFalse(long value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MinValue)]
        public void IsNotMaxValue_ulong_ShouldReturnTrue(ulong value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ulong.MaxValue)]
        public void IsNotMaxValue_ulong_ShouldReturnFalse(ulong value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        [TestCase(float.MinValue)]
        public void IsNotMaxValue_float_ShouldReturnTrue(float value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(float.MaxValue)]
        public void IsNotMaxValue_float_ShouldReturnFalse(float value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        [TestCase(double.MinValue)]
        public void IsNotMaxValue_double_ShouldReturnTrue(double value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(double.MaxValue)]
        public void IsNotMaxValue_double_ShouldReturnFalse(double value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotMaxValue_decimal_ShouldReturnTrue(decimal value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_decimal_ShouldReturnFalse_Data))]
        public void IsNotMaxValue_decimal_ShouldReturnFalse(decimal value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        [TestCase(char.MinValue)]
        public void IsNotMaxValue_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_char_ShouldReturnFalse_Data))]
        public void IsNotMaxValue_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_DateTime_ShouldReturnTrue_Data))]
        public void IsNotMaxValue_DateTime_ShouldReturnTrue(DateTime value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_DateTime_ShouldReturnFalse_Data))]
        public void IsNotMaxValue_DateTime_ShouldReturnFalse(DateTime value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_TimeSpan_ShouldReturnTrue_Data))]
        public void IsNotMaxValue_TimeSpan_ShouldReturnTrue(TimeSpan value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotMaxValueExtensionMockData), nameof(IsNotMaxValue_TimeSpan_ShouldReturnFalse_Data))]
        public void IsNotMaxValue_TimeSpan_ShouldReturnFalse(TimeSpan value)
        {
            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
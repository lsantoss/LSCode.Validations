using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotMinValueExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(sbyte.MaxValue)]
        public void IsNotMinValue_sbyte_ShouldReturnTrue(sbyte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(sbyte.MinValue)]
        public void IsNotMinValue_sbyte_ShouldReturnFalse(sbyte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MaxValue)]
        public void IsNotMinValue_byte_ShouldReturnTrue(byte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(byte.MinValue)]
        public void IsNotMinValue_byte_ShouldReturnFalse(byte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(short.MaxValue)]
        public void IsNotMinValue_short_ShouldReturnTrue(short value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(short.MinValue)]
        public void IsNotMinValue_short_ShouldReturnFalse(short value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MaxValue)]
        public void IsNotMinValue_ushort_ShouldReturnTrue(ushort value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ushort.MinValue)]
        public void IsNotMinValue_ushort_ShouldReturnFalse(ushort value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MaxValue)]
        public void IsNotMinValue_int_ShouldReturnTrue(int value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(int.MinValue)]
        public void IsNotMinValue_int_ShouldReturnFalse(int value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MaxValue)]
        public void IsNotMinValue_uint_ShouldReturnTrue(uint value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(uint.MinValue)]
        public void IsNotMinValue_uint_ShouldReturnFalse(uint value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(long.MaxValue)]
        public void IsNotMinValue_long_ShouldReturnTrue(long value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(long.MinValue)]
        public void IsNotMinValue_long_ShouldReturnFalse(long value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MaxValue)]
        public void IsNotMinValue_ulong_ShouldReturnTrue(ulong value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ulong.MinValue)]
        public void IsNotMinValue_ulong_ShouldReturnFalse(ulong value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        [TestCase(float.MaxValue)]
        public void IsNotMinValue_float_ShouldReturnTrue(float value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(float.MinValue)]
        public void IsNotMinValue_float_ShouldReturnFalse(float value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        [TestCase(double.MaxValue)]
        public void IsNotMinValue_double_ShouldReturnTrue(double value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(double.MinValue)]
        public void IsNotMinValue_double_ShouldReturnFalse(double value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotMinValue_decimal_ShouldReturnTrue(decimal value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMinValue_decimal_ShouldReturnFalse()
        {
            //Arrange
            var value = decimal.MinValue;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        public void IsNotMinValue_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(char.MinValue)]
        public void IsNotMinValue_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotMinValue_DateTime_ShouldReturnTrue()
        {
            //Arrange
            DateTime value = DateTime.UtcNow;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMinValue_DateTime_ShouldReturnFalse()
        {
            //Arrange
            var value = DateTime.MinValue;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(long.MaxValue)]
        public void IsNotMinValue_TimeSpan_ShouldReturnTrue(long tricks)
        {
            //Arrange
            var value = new TimeSpan(tricks);

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(long.MinValue)]
        public void IsNotMinValue_TimeSpan_ShouldReturnFalse(long tricks)
        {
            //Arrange
            var value = new TimeSpan(tricks);

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
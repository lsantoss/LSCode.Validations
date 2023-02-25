using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsMaxValueExtensionTest
    {
        [Test]
        [TestCase(sbyte.MaxValue)]
        public void IsMaxValue_sbyte_True_Success(sbyte value)
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
        public void IsMaxValue_sbyte_False_Success(sbyte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(byte.MaxValue)]
        public void IsMaxValue_byte_True_Success(byte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MinValue)]
        public void IsMaxValue_byte_False_Success(byte value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(short.MaxValue)]
        public void IsMaxValue_short_True_Success(short value)
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
        public void IsMaxValue_short_False_Success(short value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ushort.MaxValue)]
        public void IsMaxValue_ushort_True_Success(ushort value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MinValue)]
        public void IsMaxValue_ushort_False_Success(ushort value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(int.MaxValue)]
        public void IsMaxValue_int_True_Success(int value)
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
        public void IsMaxValue_int_False_Success(int value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(uint.MaxValue)]
        public void IsMaxValue_uint_True_Success(uint value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MinValue)]
        public void IsMaxValue_uint_False_Success(uint value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(long.MaxValue)]
        public void IsMaxValue_long_True_Success(long value)
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
        public void IsMaxValue_long_False_Success(long value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ulong.MaxValue)]
        public void IsMaxValue_ulong_True_Success(ulong value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MinValue)]
        public void IsMaxValue_ulong_False_Success(ulong value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(float.MaxValue)]
        public void IsMaxValue_float_True_Success(float value)
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
        public void IsMaxValue_float_False_Success(float value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(double.MaxValue)]
        public void IsMaxValue_double_True_Success(double value)
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
        public void IsMaxValue_double_False_Success(double value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMaxValue_decimal_True_Success()
        {
            //Arrange
            var value = decimal.MaxValue;

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
        public void IsMaxValue_decimal_False_Success(decimal value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMaxValue_char_True_Success()
        {
            //Arrange
            char value = char.MaxValue;

            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('b')]
        [TestCase(char.MinValue)]
        public void IsMaxValue_char_False_Success(char value)
        {
            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMaxValue_DateTime_True_Success()
        {
            //Arrange
            var value = DateTime.MaxValue;

            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMaxValue_DateTime_False_Success()
        {
            //Arrange
            DateTime value = DateTime.UtcNow;

            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
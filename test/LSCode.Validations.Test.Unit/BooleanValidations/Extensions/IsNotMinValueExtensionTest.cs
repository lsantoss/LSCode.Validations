using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsNotMinValueExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(sbyte.MaxValue)]
        public void IsNotMinValue_sbyte_True_Success(sbyte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(sbyte.MinValue)]
        public void IsNotMinValue_sbyte_False_Success(sbyte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MaxValue)]
        public void IsNotMinValue_byte_True_Success(byte value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(byte.MinValue)]
        public void IsNotMinValue_byte_False_Success(byte value)
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
        public void IsNotMinValue_short_True_Success(short value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(short.MinValue)]
        public void IsNotMinValue_short_False_Success(short value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MaxValue)]
        public void IsNotMinValue_ushort_True_Success(ushort value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ushort.MinValue)]
        public void IsNotMinValue_ushort_False_Success(ushort value)
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
        public void IsNotMinValue_int_True_Success(int value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(int.MinValue)]
        public void IsNotMinValue_int_False_Success(int value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MaxValue)]
        public void IsNotMinValue_uint_True_Success(uint value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(uint.MinValue)]
        public void IsNotMinValue_uint_False_Success(uint value)
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
        public void IsNotMinValue_long_True_Success(long value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(long.MinValue)]
        public void IsNotMinValue_long_False_Success(long value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MaxValue)]
        public void IsNotMinValue_ulong_True_Success(ulong value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(ulong.MinValue)]
        public void IsNotMinValue_ulong_False_Success(ulong value)
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
        public void IsNotMinValue_float_True_Success(float value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(float.MinValue)]
        public void IsNotMinValue_float_False_Success(float value)
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
        public void IsNotMinValue_double_True_Success(double value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(double.MinValue)]
        public void IsNotMinValue_double_False_Success(double value)
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
        public void IsNotMinValue_decimal_True_Success(decimal value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMinValue_decimal_False_Success()
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
        [TestCase(char.MaxValue)]
        public void IsNotMinValue_char_True_Success(char value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(char.MinValue)]
        public void IsNotMinValue_char_False_Success(char value)
        {
            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotMinValue_DateTime_True_Success()
        {
            //Arrange
            DateTime value = DateTime.UtcNow;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMinValue_DateTime_False_Success()
        {
            //Arrange
            var value = DateTime.MinValue;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
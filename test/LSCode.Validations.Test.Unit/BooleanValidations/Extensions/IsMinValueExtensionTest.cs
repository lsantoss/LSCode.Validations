using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsMinValueExtensionTest
    {
        [Test]
        [TestCase(sbyte.MinValue)]
        public void IsMinValue_sbyte_True_Success(sbyte value)
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
        public void IsMinValue_sbyte_False_Success(sbyte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(byte.MinValue)]
        public void IsMinValue_byte_True_Success(byte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1)]
        [TestCase(byte.MaxValue)]
        public void IsMinValue_byte_False_Success(byte value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(short.MinValue)]
        public void IsMinValue_short_True_Success(short value)
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
        public void IsMinValue_short_False_Success(short value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ushort.MinValue)]
        public void IsMinValue_ushort_True_Success(ushort value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1)]
        [TestCase(ushort.MaxValue)]
        public void IsMinValue_ushort_False_Success(ushort value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(int.MinValue)]
        public void IsMinValue_int_True_Success(int value)
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
        public void IsMinValue_int_False_Success(int value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(uint.MinValue)]
        public void IsMinValue_uint_True_Success(uint value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)1)]
        [TestCase(uint.MaxValue)]
        public void IsMinValue_uint_False_Success(uint value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(long.MinValue)]
        public void IsMinValue_long_True_Success(long value)
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
        public void IsMinValue_long_False_Success(long value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(ulong.MinValue)]
        public void IsMinValue_ulong_True_Success(ulong value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)1)]
        [TestCase(ulong.MaxValue)]
        public void IsMinValue_ulong_False_Success(ulong value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(float.MinValue)]
        public void IsMinValue_float_True_Success(float value)
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
        public void IsMinValue_float_False_Success(float value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(double.MinValue)]
        public void IsMinValue_double_True_Success(double value)
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
        public void IsMinValue_double_False_Success(double value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMinValue_decimal_True_Success()
        {
            //Arrange
            var value = decimal.MinValue;

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
        public void IsMinValue_decimal_False_Success(decimal value)
        {
            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMinValue_DateTime_True_Success()
        {
            //Arrange
            var value = DateTime.MinValue;

            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMinValue_DateTime_False_Success()
        {
            //Arrange
            DateTime value = DateTime.UtcNow;

            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
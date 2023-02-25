using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsNotNullExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_sbyte_True_Success(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_sbyte_False_Success(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_byte_True_Success(byte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_byte_False_Success(byte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_short_True_Success(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_short_False_Success(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNotNull_ushort_True_Success(ushort? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ushort_False_Success(ushort? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_int_True_Success(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_int_False_Success(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNotNull_uint_True_Success(uint? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_uint_False_Success(uint? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_long_True_Success(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_long_False_Success(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNotNull_ulong_True_Success(ulong? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ulong_False_Success(ulong? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        public void IsNotNull_float_True_Success(float? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_float_False_Success(float? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotNull_double_True_Success(double? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_double_False_Success(double? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotNull_decimal_True_Success(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_decimal_False_Success(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNotNull_bool_True_Success(bool? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_bool_False_Success(bool? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase('a')]
        [TestCase('1')]
        [TestCase(' ')]
        public void IsNotNull_char_True_Success(char? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_char_False_Success(char? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aa aa aa")]
        [TestCase("")]
        [TestCase(" ")]
        public void IsNotNull_string_True_Success(string value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_string_False_Success(string value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_Guid_True_Success()
        {
            //Arrange
            Guid? value = Guid.NewGuid();

            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_Guid_False_Success(Guid? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_DateTime_True_Success()
        {
            //Arrange
            DateTime? value = DateTime.UtcNow;

            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_DateTime_False_Success(DateTime? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_object_True_Success()
        {
            //Arrange
            object value = new
            {
                reason = "error",
                date = DateTime.UtcNow
            };

            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_object_False_Success(object value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
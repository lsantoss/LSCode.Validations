using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotNullExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_sbyte_ShouldReturnTrue(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_sbyte_ShouldReturnFalse(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_byte_ShouldReturnTrue(byte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_byte_ShouldReturnFalse(byte? value)
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
        public void IsNotNull_short_ShouldReturnTrue(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_short_ShouldReturnFalse(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNotNull_ushort_ShouldReturnTrue(ushort? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ushort_ShouldReturnFalse(ushort? value)
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
        public void IsNotNull_int_ShouldReturnTrue(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_int_ShouldReturnFalse(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNotNull_uint_ShouldReturnTrue(uint? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_uint_ShouldReturnFalse(uint? value)
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
        public void IsNotNull_long_ShouldReturnTrue(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_long_ShouldReturnFalse(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNotNull_ulong_ShouldReturnTrue(ulong? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ulong_ShouldReturnFalse(ulong? value)
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
        public void IsNotNull_float_ShouldReturnTrue(float? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_float_ShouldReturnFalse(float? value)
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
        public void IsNotNull_double_ShouldReturnTrue(double? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_double_ShouldReturnFalse(double? value)
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
        public void IsNotNull_decimal_ShouldReturnTrue(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_decimal_ShouldReturnFalse(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNotNull_bool_ShouldReturnTrue(bool? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_bool_ShouldReturnFalse(bool? value)
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
        public void IsNotNull_char_ShouldReturnTrue(char? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_char_ShouldReturnFalse(char? value)
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
        public void IsNotNull_string_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_string_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_Guid_ShouldReturnTrue()
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
        public void IsNotNull_Guid_ShouldReturnFalse(Guid? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_DateTime_ShouldReturnTrue()
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
        public void IsNotNull_DateTime_ShouldReturnFalse(DateTime? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(10)]
        [TestCase(long.MinValue)]
        [TestCase(long.MaxValue)]
        public void IsNotNull_TimeSpan_ShouldReturnTrue(long tricks)
        {
            //Arrange
            TimeSpan? value = new TimeSpan(tricks);

            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_TimeSpan_ShouldReturnFalse(TimeSpan? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotNull_object_ShouldReturnTrue()
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
        public void IsNotNull_object_ShouldReturnFalse(object value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
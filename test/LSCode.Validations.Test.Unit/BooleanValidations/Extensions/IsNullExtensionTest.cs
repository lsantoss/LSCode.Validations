using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNullExtensionTest
    {
        [Test]
        [TestCase(null)]
        public void IsNull_sbyte_ShouldReturnTrue(sbyte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_sbyte_ShouldReturnFalse(sbyte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_byte_ShouldReturnTrue(byte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_byte_ShouldReturnFalse(byte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_short_ShouldReturnTrue(short? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_short_ShouldReturnFalse(short? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_ushort_ShouldReturnTrue(ushort? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNull_ushort_ShouldReturnFalse(ushort? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_int_ShouldReturnTrue(int? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_int_ShouldReturnFalse(int? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_uint_ShouldReturnTrue(uint? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNull_uint_ShouldReturnFalse(uint? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_long_ShouldReturnTrue(long? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_long_ShouldReturnFalse(long? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_ulong_ShouldReturnTrue(ulong? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNull_ulong_ShouldReturnFalse(ulong? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_float_ShouldReturnTrue(float? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        public void IsNull_float_ShouldReturnFalse(float? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_double_ShouldReturnTrue(double? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNull_double_ShouldReturnFalse(double? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_decimal_ShouldReturnTrue(decimal? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNull_decimal_ShouldReturnFalse(decimal? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_bool_ShouldReturnTrue(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNull_bool_ShouldReturnFalse(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_char_ShouldReturnTrue(char? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('1')]
        [TestCase(' ')]
        public void IsNull_char_ShouldReturnFalse(char? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_string_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aa aa aa")]
        [TestCase("")]
        [TestCase(" ")]
        public void IsNull_string_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_Guid_ShouldReturnTrue(Guid? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNull_Guid_ShouldReturnFalse()
        {
            //Arrange
            Guid? value = Guid.NewGuid();

            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_DateTime_ShouldReturnTrue(DateTime? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNull_DateTime_ShouldReturnFalse()
        {
            //Arrange
            DateTime? value = DateTime.UtcNow;

            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_TimeSpan_ShouldReturnTrue(TimeSpan? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(10)]
        [TestCase(long.MinValue)]
        [TestCase(long.MaxValue)]
        public void IsNull_TimeSpan_ShouldReturnFalse(long tricks)
        {
            //Arrange
            TimeSpan? value = new TimeSpan(tricks);

            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_object_ShouldReturnTrue(object value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNull_object_ShouldReturnFalse()
        {
            //Arrange
            object value = new
            {
                reason = "error",
                date = DateTime.UtcNow
            };

            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
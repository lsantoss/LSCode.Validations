using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsNotNullExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotNullExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_sbyte_ShouldReturnTrue(sbyte value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_sbyte_Nullable_ShouldReturnTrue(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_sbyte_Nullable_ShouldReturnFalse(sbyte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_byte_ShouldReturnTrue(byte value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_byte_Nullable_ShouldReturnTrue(byte? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_byte_Nullable_ShouldReturnFalse(byte? value)
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
        public void IsNotNull_short_ShouldReturnTrue(short value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_short_Nullable_ShouldReturnTrue(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_short_Nullable_ShouldReturnFalse(short? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNotNull_ushort_ShouldReturnTrue(ushort value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNotNull_ushort_Nullable_ShouldReturnTrue(ushort? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ushort_Nullable_ShouldReturnFalse(ushort? value)
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
        public void IsNotNull_int_ShouldReturnTrue(int value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_int_Nullable_ShouldReturnTrue(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_int_Nullable_ShouldReturnFalse(int? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNotNull_uint_ShouldReturnTrue(uint value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNotNull_uint_Nullable_ShouldReturnTrue(uint? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_uint_Nullable_ShouldReturnFalse(uint? value)
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
        public void IsNotNull_long_ShouldReturnTrue(long value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_long_Nullable_ShouldReturnTrue(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_long_Nullable_ShouldReturnFalse(long? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNotNull_ulong_ShouldReturnTrue(ulong value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNotNull_ulong_Nullable_ShouldReturnTrue(ulong? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_ulong_Nullable_ShouldReturnFalse(ulong? value)
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
        public void IsNotNull_float_ShouldReturnTrue(float value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        public void IsNotNull_float_Nullable_ShouldReturnTrue(float? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_float_Nullable_ShouldReturnFalse(float? value)
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
        public void IsNotNull_double_ShouldReturnTrue(double value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotNull_double_Nullable_ShouldReturnTrue(double? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_double_Nullable_ShouldReturnFalse(double? value)
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
        public void IsNotNull_decimal_ShouldReturnTrue(decimal value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNotNull_decimal_Nullable_ShouldReturnTrue(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_decimal_Nullable_ShouldReturnFalse(decimal? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNotNull_bool_ShouldReturnTrue(bool value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNotNull_bool_Nullable_ShouldReturnTrue(bool? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_bool_Nullable_ShouldReturnFalse(bool? value)
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
        public void IsNotNull_char_ShouldReturnTrue(char value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a')]
        [TestCase('1')]
        [TestCase(' ')]
        public void IsNotNull_char_Nullable_ShouldReturnTrue(char? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_char_Nullable_ShouldReturnFalse(char? value)
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
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_Guid_ShouldReturnTrue_Data))]
        public void IsNotNull_Guid_ShouldReturnTrue(Guid value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_Guid_Nullable_ShouldReturnTrue_Data))]
        public void IsNotNull_Guid_Nullable_ShouldReturnTrue(Guid? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_Guid_Nullable_ShouldReturnFalse(Guid? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_DateTime_ShouldReturnTrue_Data))]
        public void IsNotNull_DateTime_ShouldReturnTrue(DateTime value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_DateTime_Nullable_ShouldReturnTrue_Data))]
        public void IsNotNull_DateTime_Nullable_ShouldReturnTrue(DateTime? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_DateTime_Nullable_ShouldReturnFalse(DateTime? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_TimeSpan_ShouldReturnTrue_Data))]
        public void IsNotNull_TimeSpan_ShouldReturnTrue(TimeSpan value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_TimeSpan_Nullable_ShouldReturnTrue_Data))]
        public void IsNotNull_TimeSpan_Nullable_ShouldReturnTrue(TimeSpan value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_TimeSpan_Nullable_ShouldReturnFalse(TimeSpan? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotNullExtensionMockData), nameof(IsNotNull_IEnumerable_ShouldReturnTrue_Data))]
        public void IsNotNull_IEnumerable_ShouldReturnTrue(IEnumerable<int> value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_IEnumerable_ShouldReturnFalse(IEnumerable<int> value)
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
            object value = new { reason = "error", date = DateTime.UtcNow };

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
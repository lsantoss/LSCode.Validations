using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsNullExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNullExtensionTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_sbyte_ShouldReturnFalse(sbyte value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_sbyte_Nullable_ShouldReturnTrue(sbyte? value)
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
        public void IsNull_sbyte_Nullable_ShouldReturnFalse(sbyte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_byte_ShouldReturnFalse(byte value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_byte_Nullable_ShouldReturnTrue(byte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_byte_Nullable_ShouldReturnFalse(byte? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_short_ShouldReturnFalse(short value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_short_Nullable_ShouldReturnTrue(short? value)
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
        public void IsNull_short_Nullable_ShouldReturnFalse(short? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNull_ushort_ShouldReturnFalse(ushort value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_ushort_Nullable_ShouldReturnTrue(ushort? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0)]
        [TestCase((ushort)1)]
        public void IsNull_ushort_Nullable_ShouldReturnFalse(ushort? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_int_ShouldReturnFalse(int value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_int_Nullable_ShouldReturnTrue(int? value)
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
        public void IsNull_int_Nullable_ShouldReturnFalse(int? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNull_uint_ShouldReturnFalse(uint value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_uint_Nullable_ShouldReturnTrue(uint? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void IsNull_uint_Nullable_ShouldReturnFalse(uint? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_long_ShouldReturnFalse(long value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_long_Nullable_ShouldReturnTrue(long? value)
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
        public void IsNull_long_Nullable_ShouldReturnFalse(long? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNull_ulong_ShouldReturnFalse(ulong value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_ulong_Nullable_ShouldReturnTrue(ulong? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0)]
        [TestCase((ulong)1)]
        public void IsNull_ulong_Nullable_ShouldReturnFalse(ulong? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5f)]
        [TestCase(-1f)]
        [TestCase(0f)]
        [TestCase(1f)]
        [TestCase(1.5f)]
        public void IsNull_float_ShouldReturnFalse(float value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_float_Nullable_ShouldReturnTrue(float? value)
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
        public void IsNull_float_Nullable_ShouldReturnFalse(float? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNull_double_ShouldReturnFalse(double value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_double_Nullable_ShouldReturnTrue(double? value)
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
        public void IsNull_double_Nullable_ShouldReturnFalse(double? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1.5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(1.5)]
        public void IsNull_decimal_ShouldReturnFalse(decimal value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_decimal_Nullable_ShouldReturnTrue(decimal? value)
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
        public void IsNull_decimal_Nullable_ShouldReturnFalse(decimal? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNull_bool_ShouldReturnFalse(bool value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_bool_Nullable_ShouldReturnTrue(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNull_bool_Nullable_ShouldReturnFalse(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase('a')]
        [TestCase('1')]
        [TestCase(' ')]
        public void IsNull_char_ShouldReturnFalse(char value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_char_Nullable_ShouldReturnTrue(char? value)
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
        public void IsNull_char_Nullable_ShouldReturnFalse(char? value)
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
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_Guid_ShouldReturnFalse_Data))]
        public void IsNull_Guid_ShouldReturnFalse(Guid value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_Guid_Nullable_ShouldReturnTrue(Guid? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_Guid_Nullable_ShouldReturnFalse_Data))]
        public void IsNull_Guid_Nullable_ShouldReturnFalse(Guid? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_DateTime_ShouldReturnFalse_Data))]
        public void IsNull_DateTime_ShouldReturnFalse(DateTime value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_DateTime_Nullable_ShouldReturnTrue(DateTime? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_DateTime_Nullable_ShouldReturnFalse_Data))]
        public void IsNull_DateTime_Nullable_ShouldReturnFalse(DateTime? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_TimeSpan_ShouldReturnFalse_Data))]
        public void IsNull_TimeSpan_ShouldReturnFalse(TimeSpan value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        public void IsNull_TimeSpan_Nullable_ShouldReturnTrue(TimeSpan? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_TimeSpan_Nullable_ShouldReturnFalse_Data))]
        public void IsNull_TimeSpan_Nullable_ShouldReturnFalse(TimeSpan? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_IEnumerable_ShouldReturnTrue_Data))]
        public void IsNull_IEnumerable_ShouldReturnTrue(IEnumerable<int> value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNullExtensionMockData), nameof(IsNull_IEnumerable_ShouldReturnFalse_Data))]
        public void IsNull_IEnumerable_ShouldReturnFalse(IEnumerable<int> value)
        {
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
            object value = new { reason = "error", date = DateTime.UtcNow };

            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
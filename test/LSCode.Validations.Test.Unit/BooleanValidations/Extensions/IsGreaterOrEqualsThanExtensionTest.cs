using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsGreaterOrEqualsThanExtensionTest
    {
        #region ## Region for main value with type sbyte ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_sbyte_sbyte_ShouldReturnTrue(sbyte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_sbyte_sbyte_ShouldReturnFalse(sbyte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_sbyte_byte_ShouldReturnTrue(sbyte value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_sbyte_byte_ShouldReturnFalse(sbyte value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_sbyte_short_ShouldReturnTrue(sbyte value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_sbyte_short_ShouldReturnFalse(sbyte value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ushort)1)]
        [TestCase(2, (ushort)1)]
        public void IsGreaterOrEqualsThan_sbyte_ushort_ShouldReturnTrue(sbyte value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsGreaterOrEqualsThan_sbyte_ushort_ShouldReturnFalse(sbyte value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_sbyte_int_ShouldReturnTrue(sbyte value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_sbyte_int_ShouldReturnFalse(sbyte value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (uint)1)]
        [TestCase(2, (uint)1)]
        public void IsGreaterOrEqualsThan_sbyte_uint_ShouldReturnTrue(sbyte value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsGreaterOrEqualsThan_sbyte_uint_ShouldReturnFalse(sbyte value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_sbyte_long_ShouldReturnTrue(sbyte value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_sbyte_long_ShouldReturnFalse(sbyte value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ulong)1)]
        [TestCase(2, (ulong)1)]
        public void IsGreaterOrEqualsThan_sbyte_ulong_ShouldReturnTrue(sbyte value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsGreaterOrEqualsThan_sbyte_ulong_ShouldReturnFalse(sbyte value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5f)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5f)]
        public void IsGreaterOrEqualsThan_sbyte_float_ShouldReturnTrue(sbyte value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5f)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        public void IsGreaterOrEqualsThan_sbyte_float_ShouldReturnFalse(sbyte value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_sbyte_double_ShouldReturnTrue(sbyte value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_sbyte_double_ShouldReturnFalse(sbyte value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_sbyte_decimal_ShouldReturnTrue(sbyte value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_sbyte_decimal_ShouldReturnFalse(sbyte value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type byte ##

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_byte_sbyte_ShouldReturnTrue(byte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_byte_sbyte_ShouldReturnFalse(byte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_byte_byte_ShouldReturnTrue(byte value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_byte_byte_ShouldReturnFalse(byte value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_byte_short_ShouldReturnTrue(byte value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_byte_short_ShouldReturnFalse(byte value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ushort)1)]
        [TestCase(2, (ushort)1)]
        public void IsGreaterOrEqualsThan_byte_ushort_ShouldReturnTrue(byte value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, (ushort)2)]
        public void IsGreaterOrEqualsThan_byte_ushort_ShouldReturnFalse(byte value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_byte_int_ShouldReturnTrue(byte value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_byte_int_ShouldReturnFalse(byte value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (uint)1)]
        [TestCase(2, (uint)1)]
        public void IsGreaterOrEqualsThan_byte_uint_ShouldReturnTrue(byte value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, (uint)2)]
        public void IsGreaterOrEqualsThan_byte_uint_ShouldReturnFalse(byte value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_byte_long_ShouldReturnTrue(byte value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_byte_long_ShouldReturnFalse(byte value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ulong)1)]
        [TestCase(2, (ulong)1)]
        public void IsGreaterOrEqualsThan_byte_ulong_ShouldReturnTrue(byte value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, (ulong)2)]
        public void IsGreaterOrEqualsThan_byte_ulong_ShouldReturnFalse(byte value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, -1.5f)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5f)]
        public void IsGreaterOrEqualsThan_byte_float_ShouldReturnTrue(byte value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        public void IsGreaterOrEqualsThan_byte_float_ShouldReturnFalse(byte value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_byte_double_ShouldReturnTrue(byte value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_byte_double_ShouldReturnFalse(byte value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_byte_decimal_ShouldReturnTrue(byte value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_byte_decimal_ShouldReturnFalse(byte value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type short ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_short_sbyte_ShouldReturnTrue(short value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_short_sbyte_ShouldReturnFalse(short value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_short_byte_ShouldReturnTrue(short value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_short_byte_ShouldReturnFalse(short value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_short_short_ShouldReturnTrue(short value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_short_short_ShouldReturnFalse(short value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ushort)1)]
        [TestCase(2, (ushort)1)]
        public void IsGreaterOrEqualsThan_short_ushort_ShouldReturnTrue(short value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsGreaterOrEqualsThan_short_ushort_ShouldReturnFalse(short value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_short_int_ShouldReturnTrue(short value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_short_int_ShouldReturnFalse(short value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (uint)1)]
        [TestCase(2, (uint)1)]
        public void IsGreaterOrEqualsThan_short_uint_ShouldReturnTrue(short value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsGreaterOrEqualsThan_short_uint_ShouldReturnFalse(short value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void IsGreaterOrEqualsThan_short_long_ShouldReturnTrue(short value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, 2)]
        public void IsGreaterOrEqualsThan_short_long_ShouldReturnFalse(short value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, (ulong)1)]
        [TestCase(2, (ulong)1)]
        public void IsGreaterOrEqualsThan_short_ulong_ShouldReturnTrue(short value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsGreaterOrEqualsThan_short_ulong_ShouldReturnFalse(short value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5f)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5f)]
        public void IsGreaterOrEqualsThan_short_float_ShouldReturnTrue(short value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5f)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        public void IsGreaterOrEqualsThan_short_float_ShouldReturnFalse(short value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_short_double_ShouldReturnTrue(short value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_short_double_ShouldReturnFalse(short value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2.5)]
        [TestCase(-1, -2)]
        [TestCase(-1, -1)]
        [TestCase(1, -1)]
        [TestCase(1, -1.5)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(2, 1.5)]
        public void IsGreaterOrEqualsThan_short_decimal_ShouldReturnTrue(short value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-2, -1.5)]
        [TestCase(-2, -1)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        public void IsGreaterOrEqualsThan_short_float_ShouldReturnFalse(short value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type ushort ##

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        public void IsGreaterOrEqualsThan_ushort_sbyte_ShouldReturnTrue(ushort value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        public void IsGreaterOrEqualsThan_ushort_sbyte_ShouldReturnFalse(ushort value, sbyte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        public void IsGreaterOrEqualsThan_ushort_byte_ShouldReturnTrue(ushort value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        public void IsGreaterOrEqualsThan_ushort_byte_ShouldReturnFalse(ushort value, byte comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        public void IsGreaterOrEqualsThan_ushort_short_ShouldReturnTrue(ushort value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        public void IsGreaterOrEqualsThan_ushort_short_ShouldReturnFalse(ushort value, short comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, (ushort)1)]
        [TestCase((ushort)2, (ushort)1)]
        public void IsGreaterOrEqualsThan_ushort_ushort_ShouldReturnTrue(ushort value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, (ushort)2)]
        public void IsGreaterOrEqualsThan_ushort_ushort_ShouldReturnFalse(ushort value, ushort comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        public void IsGreaterOrEqualsThan_ushort_int_ShouldReturnTrue(ushort value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        public void IsGreaterOrEqualsThan_ushort_int_ShouldReturnFalse(ushort value, int comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, (uint)1)]
        [TestCase((ushort)2, (uint)1)]
        public void IsGreaterOrEqualsThan_ushort_uint_ShouldReturnTrue(ushort value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, (uint)2)]
        public void IsGreaterOrEqualsThan_ushort_uint_ShouldReturnFalse(ushort value, uint comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        public void IsGreaterOrEqualsThan_ushort_long_ShouldReturnTrue(ushort value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        public void IsGreaterOrEqualsThan_ushort_long_ShouldReturnFalse(ushort value, long comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, (ulong)1)]
        [TestCase((ushort)2, (ulong)1)]
        public void IsGreaterOrEqualsThan_ushort_ulong_ShouldReturnTrue(ushort value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, (ulong)2)]
        public void IsGreaterOrEqualsThan_ushort_ulong_ShouldReturnFalse(ushort value, ulong comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, -1.5f)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        [TestCase((ushort)2, 1.5f)]
        public void IsGreaterOrEqualsThan_ushort_float_ShouldReturnTrue(ushort value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5f)]
        public void IsGreaterOrEqualsThan_ushort_float_ShouldReturnFalse(ushort value, float comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, -1.5)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        [TestCase((ushort)2, 1.5)]
        public void IsGreaterOrEqualsThan_ushort_double_ShouldReturnTrue(ushort value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5)]
        public void IsGreaterOrEqualsThan_ushort_double_ShouldReturnFalse(ushort value, double comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)1, -1)]
        [TestCase((ushort)1, -1.5)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)2, 1)]
        [TestCase((ushort)2, 1.5)]
        public void IsGreaterOrEqualsThan_ushort_decimal_ShouldReturnTrue(ushort value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5)]
        public void IsGreaterOrEqualsThan_ushort_decimal_ShouldReturnFalse(ushort value, decimal comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type int ##

        [Test]
        public void IsGreaterOrEqualsThan_int_sbyte_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_byte_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_short_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_ushort_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_int_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_uint_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_long_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_ulong_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_float_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_double_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_int_decimal_ShouldReturnTrue()
        {
            //Arrange
            int value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type uint ##

        [Test]
        public void IsGreaterOrEqualsThan_uint_sbyte_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_byte_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_short_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_ushort_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_int_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_uint_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_long_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_ulong_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_float_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_double_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_uint_decimal_ShouldReturnTrue()
        {
            //Arrange
            uint value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type long ##

        [Test]
        public void IsGreaterOrEqualsThan_long_sbyte_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_byte_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_short_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_ushort_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_int_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_uint_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_long_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_ulong_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_float_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_double_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_long_decimal_ShouldReturnTrue()
        {
            //Arrange
            long value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type ulong ##

        [Test]
        public void IsGreaterOrEqualsThan_ulong_sbyte_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_byte_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_short_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_ushort_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_int_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_uint_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_long_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_ulong_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_float_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_double_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_ulong_decimal_ShouldReturnTrue()
        {
            //Arrange
            ulong value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type float ##

        [Test]
        public void IsGreaterOrEqualsThan_float_sbyte_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_byte_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_short_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_ushort_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_int_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_uint_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_long_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_ulong_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_float_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_double_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_float_decimal_ShouldReturnTrue()
        {
            //Arrange
            float value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type double ##

        [Test]
        public void IsGreaterOrEqualsThan_double_sbyte_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_byte_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_short_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_ushort_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_int_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_uint_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_long_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_ulong_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_float_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_double_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_double_decimal_ShouldReturnTrue()
        {
            //Arrange
            double value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type decimal ##

        [Test]
        public void IsGreaterOrEqualsThan_decimal_sbyte_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_byte_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_short_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_ushort_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_int_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_uint_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_long_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_ulong_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_float_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_double_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsGreaterOrEqualsThan_decimal_decimal_ShouldReturnTrue()
        {
            //Arrange
            decimal value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultTrue1 = value.IsGreaterOrEqualsThan(valueSmaller);
            var resultTrue2 = value.IsGreaterOrEqualsThan(valueEqual);
            var resultFalse = value.IsGreaterOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        #endregion

        #region ## Region for main value with type char ##

        [Test]
        [TestCase('a', 'a')]
        [TestCase('b', 'a')]
        [TestCase('c', 'a')]
        public void IsGreaterOrEqualsThan_char_char_True_ShouldReturnTrue(char value, char comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a', 'b')]
        [TestCase('a', 'c')]
        [TestCase('a', 'd')]
        public void IsGreaterOrEqualsThan_char_char_False_ShouldReturnTrue(char value, char comparedValue)
        {
            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type DateTime ##

        [Test]
        [TestCase(2021, 01, 11, 2021, 01, 11)]
        [TestCase(2021, 01, 12, 2021, 01, 11)]
        [TestCase(2021, 02, 11, 2021, 01, 11)]
        [TestCase(2022, 01, 11, 2021, 01, 11)]
        [TestCase(2021, 02, 12, 2021, 01, 11)]
        [TestCase(2022, 01, 12, 2021, 01, 11)]
        [TestCase(2022, 02, 11, 2021, 01, 11)]
        [TestCase(2022, 02, 12, 2021, 01, 11)]
        public void IsGreaterOrEqualsThan_Datetime_Datetime_True_ShouldReturnTrue(int year, int month, int day, int comparedYear, int comparedMonth, int comparedDay)
        {
            //Arrange
            var value = new DateTime(year, month, day);
            var comparedValue = new DateTime(comparedYear, comparedMonth, comparedDay);

            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2021, 01, 11, 2021, 01, 12)]
        [TestCase(2021, 01, 11, 2021, 02, 11)]
        [TestCase(2021, 01, 11, 2022, 01, 11)]
        [TestCase(2021, 01, 11, 2021, 02, 12)]
        [TestCase(2021, 01, 11, 2022, 01, 12)]
        [TestCase(2021, 01, 11, 2022, 02, 11)]
        [TestCase(2021, 01, 11, 2022, 02, 12)]
        public void IsGreaterOrEqualsThan_Datetime_Datetime_False_ShouldReturnTrue(int year, int month, int day, int comparedYear, int comparedMonth, int comparedDay)
        {
            //Arrange
            var value = new DateTime(year, month, day);
            var comparedValue = new DateTime(comparedYear, comparedMonth, comparedDay);

            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type TimeSpan ##

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(10, 10)]
        [TestCase(20, 10)]
        [TestCase(100, 100)]
        [TestCase(200, 100)]
        public void IsGreaterOrEqualsThan_Timespan_Timespan_True_ShouldReturnTrue(long trikcs, long comparedTricks)
        {
            //Arrange
            var value = new TimeSpan(trikcs);
            var comparedValue = new TimeSpan(comparedTricks);

            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(10, 20)]
        [TestCase(100, 200)]
        public void IsGreaterOrEqualsThan_Timespan_Timespan_False_ShouldReturnTrue(long trikcs, long comparedTricks)
        {
            //Arrange
            var value = new TimeSpan(trikcs);
            var comparedValue = new TimeSpan(comparedTricks);

            //Act
            var result = value.IsGreaterOrEqualsThan(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion
    }
}
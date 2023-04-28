using LSCode.Validations.BooleanValidations.Extensions;
using LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions.IsNotEqualToValidationExtensionMockData;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsNotEqualToValidationExtensionTest
    {
        #region ## Region for main value with type sbyte ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_sbyte_sbyte_ShouldReturnTrue(sbyte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_sbyte_ShouldReturnFalse(sbyte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void IsNotEqualTo_sbyte_byte_ShouldReturnTrue(sbyte value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_byte_ShouldReturnFalse(sbyte value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_sbyte_short_ShouldReturnTrue(sbyte value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_short_ShouldReturnFalse(sbyte value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsNotEqualTo_sbyte_ushort_ShouldReturnTrue(sbyte value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_sbyte_ushort_ShouldReturnFalse(sbyte value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_sbyte_int_ShouldReturnTrue(sbyte value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_int_ShouldReturnFalse(sbyte value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(0, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsNotEqualTo_sbyte_uint_ShouldReturnTrue(sbyte value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_sbyte_uint_ShouldReturnFalse(sbyte value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_sbyte_long_ShouldReturnTrue(sbyte value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_long_ShouldReturnFalse(sbyte value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(0, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsNotEqualTo_sbyte_ulong_ShouldReturnTrue(sbyte value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_sbyte_ulong_ShouldReturnFalse(sbyte value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5f)]
        public void IsNotEqualTo_sbyte_float_ShouldReturnTrue(sbyte value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_float_ShouldReturnFalse(sbyte value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_sbyte_double_ShouldReturnTrue(sbyte value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_double_ShouldReturnFalse(sbyte value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_sbyte_decimal_ShouldReturnTrue(sbyte value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_sbyte_decimal_ShouldReturnFalse(sbyte value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type byte ##

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_byte_sbyte_ShouldReturnTrue(byte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_sbyte_ShouldReturnFalse(byte value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void IsNotEqualTo_byte_byte_ShouldReturnTrue(byte value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_byte_ShouldReturnFalse(byte value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_byte_short_ShouldReturnTrue(byte value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_short_ShouldReturnFalse(byte value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsNotEqualTo_byte_ushort_ShouldReturnTrue(byte value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_byte_ushort_ShouldReturnFalse(byte value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_byte_int_ShouldReturnTrue(byte value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_int_ShouldReturnFalse(byte value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsNotEqualTo_byte_uint_ShouldReturnTrue(byte value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_byte_uint_ShouldReturnFalse(byte value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_byte_long_ShouldReturnTrue(byte value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_long_ShouldReturnFalse(byte value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsNotEqualTo_byte_ulong_ShouldReturnTrue(byte value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_byte_ulong_ShouldReturnFalse(byte value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5f)]
        public void IsNotEqualTo_byte_float_ShouldReturnTrue(byte value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_float_ShouldReturnFalse(byte value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_byte_double_ShouldReturnTrue(byte value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_double_ShouldReturnFalse(byte value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_byte_decimal_ShouldReturnTrue(byte value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_byte_decimal_ShouldReturnFalse(byte value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type short ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_short_sbyte_ShouldReturnTrue(short value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_sbyte_ShouldReturnFalse(short value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void IsNotEqualTo_short_byte_ShouldReturnTrue(short value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_byte_ShouldReturnFalse(short value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_short_short_ShouldReturnTrue(short value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_short_ShouldReturnFalse(short value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsNotEqualTo_short_ushort_ShouldReturnTrue(short value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_short_ushort_ShouldReturnFalse(short value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_short_int_ShouldReturnTrue(short value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_int_ShouldReturnFalse(short value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(0, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsNotEqualTo_short_uint_ShouldReturnTrue(short value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_short_uint_ShouldReturnFalse(short value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_short_long_ShouldReturnTrue(short value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_long_ShouldReturnFalse(short value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(0, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsNotEqualTo_short_ulong_ShouldReturnTrue(short value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_short_ulong_ShouldReturnFalse(short value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5f)]
        public void IsNotEqualTo_short_float_ShouldReturnTrue(short value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_float_ShouldReturnFalse(short value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_short_double_ShouldReturnTrue(short value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_double_ShouldReturnFalse(short value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_short_decimal_ShouldReturnTrue(short value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_short_decimal_ShouldReturnFalse(short value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type ushort ##

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, -2)]
        public void IsNotEqualTo_ushort_sbyte_ShouldReturnTrue(ushort value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_sbyte_ShouldReturnFalse(ushort value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 2)]
        public void IsNotEqualTo_ushort_byte_ShouldReturnTrue(ushort value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_byte_ShouldReturnFalse(ushort value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, -2)]
        public void IsNotEqualTo_ushort_short_ShouldReturnTrue(ushort value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_short_ShouldReturnFalse(ushort value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, (ushort)1)]
        [TestCase((ushort)1, (ushort)2)]
        public void IsNotEqualTo_ushort_ushort_ShouldReturnTrue(ushort value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, (ushort)0)]
        [TestCase((ushort)1, (ushort)1)]
        public void IsNotEqualTo_ushort_ushort_ShouldReturnFalse(ushort value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, -2)]
        public void IsNotEqualTo_ushort_int_ShouldReturnTrue(ushort value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_int_ShouldReturnFalse(ushort value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, (uint)1)]
        [TestCase((ushort)1, (uint)2)]
        public void IsNotEqualTo_ushort_uint_ShouldReturnTrue(ushort value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, (uint)0)]
        [TestCase((ushort)1, (uint)1)]
        public void IsNotEqualTo_ushort_uint_ShouldReturnFalse(ushort value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, -2)]
        public void IsNotEqualTo_ushort_long_ShouldReturnTrue(ushort value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_long_ShouldReturnFalse(ushort value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, (ulong)1)]
        [TestCase((ushort)1, (ulong)2)]
        public void IsNotEqualTo_ushort_ulong_ShouldReturnTrue(ushort value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, (ulong)0)]
        [TestCase((ushort)1, (ulong)1)]
        public void IsNotEqualTo_ushort_ulong_ShouldReturnFalse(ushort value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)0, 1.5f)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5f)]
        [TestCase((ushort)1, -2)]
        [TestCase((ushort)1, -2.5f)]
        public void IsNotEqualTo_ushort_float_ShouldReturnTrue(ushort value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_float_ShouldReturnFalse(ushort value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)0, 1.5)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5)]
        [TestCase((ushort)1, -2)]
        [TestCase((ushort)1, -2.5)]
        public void IsNotEqualTo_ushort_double_ShouldReturnTrue(ushort value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_double_ShouldReturnFalse(ushort value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ushort)0, 1)]
        [TestCase((ushort)0, 1.5)]
        [TestCase((ushort)1, 2)]
        [TestCase((ushort)1, 2.5)]
        [TestCase((ushort)1, -2)]
        [TestCase((ushort)1, -2.5)]
        public void IsNotEqualTo_ushort_decimal_ShouldReturnTrue(ushort value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ushort)0, 0)]
        [TestCase((ushort)1, 1)]
        public void IsNotEqualTo_ushort_decimal_ShouldReturnFalse(ushort value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type int ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_int_sbyte_ShouldReturnTrue(int value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_sbyte_ShouldReturnFalse(int value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void IsNotEqualTo_int_byte_ShouldReturnTrue(int value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_byte_ShouldReturnFalse(int value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_int_short_ShouldReturnTrue(int value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_short_ShouldReturnFalse(int value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsNotEqualTo_int_ushort_ShouldReturnTrue(int value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_int_ushort_ShouldReturnFalse(int value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_int_int_ShouldReturnTrue(int value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_int_ShouldReturnFalse(int value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(0, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsNotEqualTo_int_uint_ShouldReturnTrue(int value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_int_uint_ShouldReturnFalse(int value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_int_long_ShouldReturnTrue(int value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_long_ShouldReturnFalse(int value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(0, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsNotEqualTo_int_ulong_ShouldReturnTrue(int value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_int_ulong_ShouldReturnFalse(int value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5f)]
        public void IsNotEqualTo_int_float_ShouldReturnTrue(int value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_float_ShouldReturnFalse(int value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_int_double_ShouldReturnTrue(int value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_double_ShouldReturnFalse(int value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_int_decimal_ShouldReturnTrue(int value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_int_decimal_ShouldReturnFalse(int value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, -2)]
        public void IsNotEqualTo_uint_sbyte_ShouldReturnTrue(uint value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        #endregion

        #region ## Region for main value with type uint ##

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_sbyte_ShouldReturnFalse(uint value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        public void IsNotEqualTo_uint_byte_ShouldReturnTrue(uint value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_byte_ShouldReturnFalse(uint value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, -2)]
        public void IsNotEqualTo_uint_short_ShouldReturnTrue(uint value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_short_ShouldReturnFalse(uint value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, (ushort)1)]
        [TestCase((uint)1, (ushort)2)]
        public void IsNotEqualTo_uint_ushort_ShouldReturnTrue(uint value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, (ushort)0)]
        [TestCase((uint)1, (ushort)1)]
        public void IsNotEqualTo_uint_ushort_ShouldReturnFalse(uint value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, -2)]
        public void IsNotEqualTo_uint_int_ShouldReturnTrue(uint value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_int_ShouldReturnFalse(uint value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, (uint)1)]
        [TestCase((uint)1, (uint)2)]
        public void IsNotEqualTo_uint_uint_ShouldReturnTrue(uint value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, (uint)0)]
        [TestCase((uint)1, (uint)1)]
        public void IsNotEqualTo_uint_uint_ShouldReturnFalse(uint value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, -2)]
        public void IsNotEqualTo_uint_long_ShouldReturnTrue(uint value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_long_ShouldReturnFalse(uint value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, (ulong)1)]
        [TestCase((uint)1, (ulong)2)]
        public void IsNotEqualTo_uint_ulong_ShouldReturnTrue(uint value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, (ulong)0)]
        [TestCase((uint)1, (ulong)1)]
        public void IsNotEqualTo_uint_ulong_ShouldReturnFalse(uint value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)0, 1.5f)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, 2.5f)]
        [TestCase((uint)1, -2)]
        [TestCase((uint)1, -2.5f)]
        public void IsNotEqualTo_uint_float_ShouldReturnTrue(uint value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_float_ShouldReturnFalse(uint value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)0, 1.5)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, 2.5)]
        [TestCase((uint)1, -2)]
        [TestCase((uint)1, -2.5)]
        public void IsNotEqualTo_uint_double_ShouldReturnTrue(uint value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_double_ShouldReturnFalse(uint value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)0, 1.5)]
        [TestCase((uint)1, 2)]
        [TestCase((uint)1, 2.5)]
        [TestCase((uint)1, -2)]
        [TestCase((uint)1, -2.5)]
        public void IsNotEqualTo_uint_decimal_ShouldReturnTrue(uint value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((uint)0, 0)]
        [TestCase((uint)1, 1)]
        public void IsNotEqualTo_uint_decimal_ShouldReturnFalse(uint value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type long ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_long_sbyte_ShouldReturnTrue(long value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }


        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_sbyte_ShouldReturnFalse(long value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void IsNotEqualTo_long_byte_ShouldReturnTrue(long value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_byte_ShouldReturnFalse(long value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_long_short_ShouldReturnTrue(long value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_short_ShouldReturnFalse(long value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(1, (ushort)2)]
        public void IsNotEqualTo_long_ushort_ShouldReturnTrue(long value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_long_ushort_ShouldReturnFalse(long value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_long_int_ShouldReturnTrue(long value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_int_ShouldReturnFalse(long value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (uint)1)]
        [TestCase(0, (uint)1)]
        [TestCase(1, (uint)2)]
        public void IsNotEqualTo_long_uint_ShouldReturnTrue(long value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_long_uint_ShouldReturnFalse(long value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, -2)]
        public void IsNotEqualTo_long_long_ShouldReturnTrue(long value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_long_ShouldReturnFalse(long value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ulong)1)]
        [TestCase(0, (ulong)1)]
        [TestCase(1, (ulong)2)]
        public void IsNotEqualTo_long_ulong_ShouldReturnTrue(long value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_long_ulong_ShouldReturnFalse(long value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5f)]
        public void IsNotEqualTo_long_float_ShouldReturnTrue(long value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_float_ShouldReturnFalse(long value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_long_double_ShouldReturnTrue(long value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_double_ShouldReturnFalse(long value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1, -2.5)]
        public void IsNotEqualTo_long_decimal_ShouldReturnTrue(long value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_long_decimal_ShouldReturnFalse(long value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type ulong ##

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, -2)]
        public void IsNotEqualTo_ulong_sbyte_ShouldReturnTrue(ulong value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }


        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_sbyte_ShouldReturnFalse(ulong value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 2)]
        public void IsNotEqualTo_ulong_byte_ShouldReturnTrue(ulong value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_byte_ShouldReturnFalse(ulong value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, -1)]
        [TestCase((ulong)1, -2)]
        public void IsNotEqualTo_ulong_short_ShouldReturnTrue(ulong value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_short_ShouldReturnFalse(ulong value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, (ushort)1)]
        [TestCase((ulong)1, (ushort)2)]
        public void IsNotEqualTo_ulong_ushort_ShouldReturnTrue(ulong value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, (ushort)0)]
        [TestCase((ulong)1, (ushort)1)]
        public void IsNotEqualTo_ulong_ushort_ShouldReturnFalse(ulong value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, -1)]
        [TestCase((ulong)1, -2)]
        public void IsNotEqualTo_ulong_int_ShouldReturnTrue(ulong value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_int_ShouldReturnFalse(ulong value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, (uint)1)]
        [TestCase((ulong)1, (uint)2)]
        public void IsNotEqualTo_ulong_uint_ShouldReturnTrue(ulong value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, (uint)0)]
        [TestCase((ulong)1, (uint)1)]
        public void IsNotEqualTo_ulong_uint_ShouldReturnFalse(ulong value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, -1)]
        [TestCase((ulong)1, -2)]
        public void IsNotEqualTo_ulong_long_ShouldReturnTrue(ulong value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_long_ShouldReturnFalse(ulong value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, (ulong)1)]
        [TestCase((ulong)1, (ulong)2)]
        public void IsNotEqualTo_ulong_ulong_ShouldReturnTrue(ulong value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, (ulong)0)]
        [TestCase((ulong)1, (ulong)1)]
        public void IsNotEqualTo_ulong_ulong_ShouldReturnFalse(ulong value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)0, 1.5f)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, 2.5f)]
        [TestCase((ulong)1, -2)]
        [TestCase((ulong)1, -2.5f)]
        public void IsNotEqualTo_ulong_float_ShouldReturnTrue(ulong value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_float_ShouldReturnFalse(ulong value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)0, 1.5)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, 2.5)]
        [TestCase((ulong)1, -2)]
        [TestCase((ulong)1, -2.5)]
        public void IsNotEqualTo_ulong_double_ShouldReturnTrue(ulong value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_double_ShouldReturnFalse(ulong value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase((ulong)0, 1)]
        [TestCase((ulong)0, 1.5)]
        [TestCase((ulong)1, 2)]
        [TestCase((ulong)1, 2.5)]
        [TestCase((ulong)1, -2)]
        [TestCase((ulong)1, -2.5)]
        public void IsNotEqualTo_ulong_decimal_ShouldReturnTrue(ulong value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase((ulong)0, 0)]
        [TestCase((ulong)1, 1)]
        public void IsNotEqualTo_ulong_decimal_ShouldReturnFalse(ulong value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type float ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        public void IsNotEqualTo_float_sbyte_ShouldReturnTrue(float value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_sbyte_ShouldReturnFalse(float value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        public void IsNotEqualTo_float_byte_ShouldReturnTrue(float value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_byte_ShouldReturnFalse(float value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        public void IsNotEqualTo_float_short_ShouldReturnTrue(float value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_short_ShouldReturnFalse(float value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5f, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5f, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5f, (ushort)2)]
        public void IsNotEqualTo_float_ushort_ShouldReturnTrue(float value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_float_ushort_ShouldReturnFalse(float value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        public void IsNotEqualTo_float_int_ShouldReturnTrue(float value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_int_ShouldReturnFalse(float value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5f, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5f, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5f, (ushort)2)]
        public void IsNotEqualTo_float_uint_ShouldReturnTrue(float value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_float_uint_ShouldReturnFalse(float value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        public void IsNotEqualTo_float_long_ShouldReturnTrue(float value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_long_ShouldReturnFalse(float value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5f, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5f, (ushort)0)]
        [TestCase(0.5f, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5f, (ushort)2)]
        public void IsNotEqualTo_float_ulong_ShouldReturnTrue(float value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_float_ulong_ShouldReturnFalse(float value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5f, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5f, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5f, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5f, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5f, -2.5f)]
        public void IsNotEqualTo_float_float_ShouldReturnTrue(float value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_float_ShouldReturnFalse(float value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5f, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5f, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5f, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5f, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5f, -2.5)]
        public void IsNotEqualTo_float_double_ShouldReturnTrue(float value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_double_ShouldReturnFalse(float value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5f, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1.5f, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5f, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(-1.5f, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5f, 1)]
        [TestCase(0, 1.5)]
        [TestCase(0.5f, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5f, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1.5f, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5f, -2)]
        [TestCase(1, -2.5)]
        [TestCase(1.5f, -2.5)]
        public void IsNotEqualTo_float_decimal_ShouldReturnTrue(float value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_float_decimal_ShouldReturnFalse(float value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type double ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_double_sbyte_ShouldReturnTrue(double value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_sbyte_ShouldReturnFalse(double value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        public void IsNotEqualTo_double_byte_ShouldReturnTrue(double value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_byte_ShouldReturnFalse(double value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_double_short_ShouldReturnTrue(double value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_short_ShouldReturnFalse(double value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_double_ushort_ShouldReturnTrue(double value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_double_ushort_ShouldReturnFalse(double value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_double_int_ShouldReturnTrue(double value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_int_ShouldReturnFalse(double value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_double_uint_ShouldReturnTrue(double value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_double_uint_ShouldReturnFalse(double value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_double_long_ShouldReturnTrue(double value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_long_ShouldReturnFalse(double value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)0)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_double_ulong_ShouldReturnTrue(double value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_double_ulong_ShouldReturnFalse(double value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5, -2.5f)]
        public void IsNotEqualTo_double_float_ShouldReturnTrue(double value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_float_ShouldReturnFalse(double value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5, -2.5)]
        public void IsNotEqualTo_double_double_ShouldReturnTrue(double value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_double_ShouldReturnFalse(double value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1.5, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(-1.5, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5)]
        [TestCase(0.5, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1.5, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5)]
        [TestCase(1.5, -2.5)]
        public void IsNotEqualTo_double_decimal_ShouldReturnTrue(double value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_double_decimal_ShouldReturnFalse(double value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type decimal ##

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_decimal_sbyte_ShouldReturnTrue(decimal value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_sbyte_ShouldReturnFalse(decimal value, sbyte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        public void IsNotEqualTo_decimal_byte_ShouldReturnTrue(decimal value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_byte_ShouldReturnFalse(decimal value, byte comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_decimal_short_ShouldReturnTrue(decimal value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_short_ShouldReturnFalse(decimal value, short comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_decimal_ushort_ShouldReturnTrue(decimal value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ushort)0)]
        [TestCase(1, (ushort)1)]
        public void IsNotEqualTo_decimal_ushort_ShouldReturnFalse(decimal value, ushort comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_decimal_int_ShouldReturnTrue(decimal value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_int_ShouldReturnFalse(decimal value, int comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_decimal_uint_ShouldReturnTrue(decimal value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (uint)0)]
        [TestCase(1, (uint)1)]
        public void IsNotEqualTo_decimal_uint_ShouldReturnFalse(decimal value, uint comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        public void IsNotEqualTo_decimal_long_ShouldReturnTrue(decimal value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_long_ShouldReturnFalse(decimal value, long comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, (ushort)1)]
        [TestCase(-1.5, (ushort)1)]
        [TestCase(0, (ushort)1)]
        [TestCase(0.5, (ushort)0)]
        [TestCase(0.5, (ushort)1)]
        [TestCase(1, (ushort)2)]
        [TestCase(1.5, (ushort)2)]
        public void IsNotEqualTo_decimal_ulong_ShouldReturnTrue(decimal value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(0, (ulong)0)]
        [TestCase(1, (ulong)1)]
        public void IsNotEqualTo_decimal_ulong_ShouldReturnFalse(decimal value, ulong comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5, -2.5f)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5, 1.5f)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5, 1.5f)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5, 2.5f)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5, -2.5f)]
        public void IsNotEqualTo_decimal_float_ShouldReturnTrue(decimal value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_float_ShouldReturnFalse(decimal value, float comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5f)]
        [TestCase(-1.5, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5f)]
        [TestCase(-1.5, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5f)]
        [TestCase(0.5, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5f)]
        [TestCase(1.5, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5f)]
        [TestCase(1.5, -2.5)]
        public void IsNotEqualTo_decimal_double_ShouldReturnTrue(decimal value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_double_ShouldReturnFalse(decimal value, double comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(-1, -2)]
        [TestCase(-1.5, -2)]
        [TestCase(-1, -2.5)]
        [TestCase(-1.5, -2.5)]
        [TestCase(-1, 1)]
        [TestCase(-1.5, 1)]
        [TestCase(-1, 1.5)]
        [TestCase(-1.5, 1.5)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1)]
        [TestCase(0, 1.5)]
        [TestCase(0.5, 1.5)]
        [TestCase(1, 2)]
        [TestCase(1.5, 2)]
        [TestCase(1, 2.5)]
        [TestCase(1.5, 2.5)]
        [TestCase(1, -2)]
        [TestCase(1.5, -2)]
        [TestCase(1, -2.5)]
        [TestCase(1.5, -2.5)]
        public void IsNotEqualTo_decimal_decimal_ShouldReturnTrue(decimal value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void IsNotEqualTo_decimal_decimal_ShouldReturnFalse(decimal value, decimal comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type bool ##

        [Test]
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void IsNotEqualTo_bool_bool_ShouldReturnTrue(bool value, bool comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true, true)]
        [TestCase(false, false)]
        public void IsNotEqualTo_bool_bool_ShouldReturnFalse(bool value, bool comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type char ##

        [Test]
        [TestCase('a', 'b')]
        [TestCase('b', 'a')]
        [TestCase('c', 'a')]
        public void IsNotEqualTo_char_char_ShouldReturnTrue(char value, char comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase('a', 'a')]
        [TestCase('b', 'b')]
        [TestCase('c', 'c')]
        public void IsNotEqualTo_char_char_ShouldReturnFalse(char value, char comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type string ##

        [Test]
        [TestCase(null, "string")]
        [TestCase("", "string")]
        [TestCase(" ", "string")]
        [TestCase("string", "string test")]
        public void IsNotEqualTo_string_string_ShouldReturnTrue(string value, string comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase(" ", " ")]
        [TestCase("string", "string")]
        public void IsNotEqualTo_string_string_ShouldReturnFalse(string value, string comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_string_Guid_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_string_Guid_ShouldReturnTrue(string value, Guid comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_string_Guid_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_string_Guid_ShouldReturnFalse(string value, Guid comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type Guid ##

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Guid_Guid_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_Guid_Guid_ShouldReturnTrue(Guid value, Guid comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Guid_Guid_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_Guid_Guid_ShouldReturnFalse(Guid value, Guid comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Guid_string_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_Guid_string_ShouldReturnTrue(Guid value, string comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Guid_string_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_Guid_string_ShouldReturnFalse(Guid value, string comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type DateTime ##

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Datetime_Datetime_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_Datetime_Datetime_ShouldReturnTrue(DateTime value, DateTime comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_Datetime_Datetime_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_Datetime_Datetime_ShouldReturnFalse(DateTime value, DateTime comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type TimeSpan ##

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnTrue(TimeSpan value, TimeSpan comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnFalse(TimeSpan value, TimeSpan comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region ## Region for main value with type IEnumerable ##

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnTrue_Data))]
        public void IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnTrue(IEnumerable<int> value, IEnumerable<int> comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCaseSource(typeof(IsNotEqualToValidationExtensionMockData), nameof(IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnFalse_Data))]
        public void IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnFalse(IEnumerable<int> value, IEnumerable<int> comparedValue)
        {
            //Act
            var result = value.IsNotEqualTo(comparedValue);

            //Assert
            Assert.That(result, Is.False);
        }

        #endregion
    }
}
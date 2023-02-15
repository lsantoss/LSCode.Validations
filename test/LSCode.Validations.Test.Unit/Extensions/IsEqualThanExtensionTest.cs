using NUnit.Framework;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class IsEqualThanExtensionTest
    {
        [Test]
        public void IsEqualThan_sbyte_sbyte_Success()
        {
            //Arrange
            sbyte value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_byte_Success()
        {
            //Arrange
            sbyte value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_short_Success()
        {
            //Arrange
            sbyte value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_ushort_Success()
        {
            //Arrange
            sbyte value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_int_Success()
        {
            //Arrange
            sbyte value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_uint_Success()
        {
            //Arrange
            sbyte value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_long_Success()
        {
            //Arrange
            sbyte value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_ulong_Success()
        {
            //Arrange
            sbyte value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_float_Success()
        {
            //Arrange
            sbyte value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_double_Success()
        {
            //Arrange
            sbyte value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_sbyte_decimal_Success()
        {
            //Arrange
            sbyte value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_byte_sbyte_Success()
        {
            //Arrange
            byte value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_byte_Success()
        {
            //Arrange
            byte value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_short_Success()
        {
            //Arrange
            byte value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_ushort_Success()
        {
            //Arrange
            byte value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_int_Success()
        {
            //Arrange
            byte value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_uint_Success()
        {
            //Arrange
            byte value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_long_Success()
        {
            //Arrange
            byte value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_ulong_Success()
        {
            //Arrange
            byte value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_float_Success()
        {
            //Arrange
            byte value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_double_Success()
        {
            //Arrange
            byte value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_byte_decimal_Success()
        {
            //Arrange
            byte value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_short_sbyte_Success()
        {
            //Arrange
            short value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_byte_Success()
        {
            //Arrange
            short value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_short_Success()
        {
            //Arrange
            short value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_ushort_Success()
        {
            //Arrange
            short value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_int_Success()
        {
            //Arrange
            short value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_uint_Success()
        {
            //Arrange
            short value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_long_Success()
        {
            //Arrange
            short value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_ulong_Success()
        {
            //Arrange
            short value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_float_Success()
        {
            //Arrange
            short value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_double_Success()
        {
            //Arrange
            short value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_short_decimal_Success()
        {
            //Arrange
            short value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_ushort_sbyte_Success()
        {
            //Arrange
            ushort value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_byte_Success()
        {
            //Arrange
            ushort value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_short_Success()
        {
            //Arrange
            ushort value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_ushort_Success()
        {
            //Arrange
            ushort value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_int_Success()
        {
            //Arrange
            ushort value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_uint_Success()
        {
            //Arrange
            ushort value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_long_Success()
        {
            //Arrange
            ushort value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_ulong_Success()
        {
            //Arrange
            ushort value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_float_Success()
        {
            //Arrange
            ushort value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_double_Success()
        {
            //Arrange
            ushort value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ushort_decimal_Success()
        {
            //Arrange
            ushort value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_int_sbyte_Success()
        {
            //Arrange
            int value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_byte_Success()
        {
            //Arrange
            int value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_short_Success()
        {
            //Arrange
            int value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_ushort_Success()
        {
            //Arrange
            int value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_int_Success()
        {
            //Arrange
            int value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_uint_Success()
        {
            //Arrange
            int value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_long_Success()
        {
            //Arrange
            int value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_ulong_Success()
        {
            //Arrange
            int value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_float_Success()
        {
            //Arrange
            int value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_double_Success()
        {
            //Arrange
            int value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_int_decimal_Success()
        {
            //Arrange
            int value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_uint_sbyte_Success()
        {
            //Arrange
            uint value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_byte_Success()
        {
            //Arrange
            uint value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_short_Success()
        {
            //Arrange
            uint value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_ushort_Success()
        {
            //Arrange
            uint value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_int_Success()
        {
            //Arrange
            uint value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_uint_Success()
        {
            //Arrange
            uint value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_long_Success()
        {
            //Arrange
            uint value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_ulong_Success()
        {
            //Arrange
            uint value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_float_Success()
        {
            //Arrange
            uint value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_double_Success()
        {
            //Arrange
            uint value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_uint_decimal_Success()
        {
            //Arrange
            uint value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_long_sbyte_Success()
        {
            //Arrange
            long value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_byte_Success()
        {
            //Arrange
            long value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_short_Success()
        {
            //Arrange
            long value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_ushort_Success()
        {
            //Arrange
            long value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_int_Success()
        {
            //Arrange
            long value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_uint_Success()
        {
            //Arrange
            long value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_long_Success()
        {
            //Arrange
            long value = 5;
            long valueEqual = 5;
            long valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_ulong_Success()
        {
            //Arrange
            long value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_float_Success()
        {
            //Arrange
            long value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_double_Success()
        {
            //Arrange
            long value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_long_decimal_Success()
        {
            //Arrange
            long value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_ulong_sbyte_Success()
        {
            //Arrange
            ulong value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_byte_Success()
        {
            //Arrange
            ulong value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_short_Success()
        {
            //Arrange
            ulong value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_ushort_Success()
        {
            //Arrange
            ulong value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_int_Success()
        {
            //Arrange
            ulong value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_uint_Success()
        {
            //Arrange
            ulong value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_long_Success()
        {
            //Arrange
            ulong value = 5;
            long valueEqual = 5;
            long valueDifferent = -7;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_ulong_Success()
        {
            //Arrange
            ulong value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_float_Success()
        {
            //Arrange
            ulong value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_double_Success()
        {
            //Arrange
            ulong value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_ulong_decimal_Success()
        {
            //Arrange
            ulong value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_float_sbyte_Success()
        {
            //Arrange
            float value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_byte_Success()
        {
            //Arrange
            float value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_short_Success()
        {
            //Arrange
            float value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_ushort_Success()
        {
            //Arrange
            float value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_int_Success()
        {
            //Arrange
            float value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_uint_Success()
        {
            //Arrange
            float value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_long_Success()
        {
            //Arrange
            float value = 5;
            long valueEqual = 5;
            long valueDifferent = -7;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_ulong_Success()
        {
            //Arrange
            float value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_float_Success()
        {
            //Arrange
            float value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_double_Success()
        {
            //Arrange
            float value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_float_decimal_Success()
        {
            //Arrange
            float value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_double_sbyte_Success()
        {
            //Arrange
            double value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_byte_Success()
        {
            //Arrange
            double value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_short_Success()
        {
            //Arrange
            double value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_ushort_Success()
        {
            //Arrange
            double value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_int_Success()
        {
            //Arrange
            double value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_uint_Success()
        {
            //Arrange
            double value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_long_Success()
        {
            //Arrange
            double value = 5;
            long valueEqual = 5;
            long valueDifferent = -7;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_ulong_Success()
        {
            //Arrange
            double value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_float_Success()
        {
            //Arrange
            double value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_double_Success()
        {
            //Arrange
            double value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_double_decimal_Success()
        {
            //Arrange
            double value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_decimal_sbyte_Success()
        {
            //Arrange
            decimal value = 5;
            sbyte valueEqual = 5;
            sbyte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_byte_Success()
        {
            //Arrange
            decimal value = 5;
            byte valueEqual = 5;
            byte valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_short_Success()
        {
            //Arrange
            decimal value = 5;
            short valueEqual = 5;
            short valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_ushort_Success()
        {
            //Arrange
            decimal value = 5;
            ushort valueEqual = 5;
            ushort valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_int_Success()
        {
            //Arrange
            decimal value = 5;
            int valueEqual = 5;
            int valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_uint_Success()
        {
            //Arrange
            decimal value = 5;
            uint valueEqual = 5;
            uint valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_long_Success()
        {
            //Arrange
            decimal value = 5;
            long valueEqual = 5;
            long valueDifferent = -7;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_ulong_Success()
        {
            //Arrange
            decimal value = 5;
            ulong valueEqual = 5;
            ulong valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_float_Success()
        {
            //Arrange
            decimal value = 5;
            float valueEqual = 5;
            float valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_double_Success()
        {
            //Arrange
            decimal value = 5;
            double valueEqual = 5;
            double valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_decimal_decimal_Success()
        {
            //Arrange
            decimal value = 5;
            decimal valueEqual = 5;
            decimal valueDifferent = 6;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }


        [Test]
        public void IsEqualThan_bool_bool_Success()
        {
            //Arrange
            bool value = true;
            bool valueEqual = true;
            bool valueDifferent = false;

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_string_string_Success()
        {
            //Arrange
            string value = "test";
            string valueEqual = "test";
            string valueDifferent = "my test";

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_string_guid_Success()
        {
            //Arrange
            string value = "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67";
            Guid valueEqual = Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67");
            Guid valueDifferent = Guid.Parse("2f3d1a60-b870-4375-8874-2b8fe359518e");

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_guid_guid_Success()
        {
            //Arrange
            Guid value = Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67");
            Guid valueEqual = Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67");
            Guid valueDifferent = Guid.Parse("2f3d1a60-b870-4375-8874-2b8fe359518e");

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_guid_string_Success()
        {
            //Arrange
            Guid value = Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67");
            string valueEqual = "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67";
            string valueDifferent = "2f3d1a60-b870-4375-8874-2b8fe359518e";

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_datetime_datetime_Success()
        {
            //Arrange
            DateTime value = new(2023, 2, 14);
            DateTime valueEqual = new(2023, 2, 14);
            DateTime valueDifferent = new(2024, 3, 15);

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void IsEqualThan_object_object_Success()
        {
            //Arrange
            object value = new
            {
                reason = "reason",
                date = new DateTime(2023, 2, 14)
            };

            object valueEqual = new
            {
                reason = "reason",
                date = new DateTime(2023, 2, 14)
            };

            object valueDifferent = new
            {
                reason = "reason different",
                date = new DateTime(2024, 5, 16)
            };

            //Act
            var resultTrue = value.IsEqualThan(valueEqual);
            var resultFalse = value.IsEqualThan(valueDifferent);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }
    }
}
using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsLowerOrEqualsThanExtentionTest
    {
        [Test]
        public void IsLowerOrEqualsThan_sbyte_sbyte_Success()
        {
            //Arrange
            sbyte value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_byte_Success()
        {
            //Arrange
            sbyte value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_short_Success()
        {
            //Arrange
            sbyte value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_ushort_Success()
        {
            //Arrange
            sbyte value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_int_Success()
        {
            //Arrange
            sbyte value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_uint_Success()
        {
            //Arrange
            sbyte value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_long_Success()
        {
            //Arrange
            sbyte value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_ulong_Success()
        {
            //Arrange
            sbyte value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_float_Success()
        {
            //Arrange
            sbyte value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_double_Success()
        {
            //Arrange
            sbyte value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_sbyte_decimal_Success()
        {
            //Arrange
            sbyte value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_byte_sbyte_Success()
        {
            //Arrange
            byte value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_byte_Success()
        {
            //Arrange
            byte value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_short_Success()
        {
            //Arrange
            byte value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_ushort_Success()
        {
            //Arrange
            byte value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_int_Success()
        {
            //Arrange
            byte value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_uint_Success()
        {
            //Arrange
            byte value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_long_Success()
        {
            //Arrange
            byte value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_ulong_Success()
        {
            //Arrange
            byte value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_float_Success()
        {
            //Arrange
            byte value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_double_Success()
        {
            //Arrange
            byte value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_byte_decimal_Success()
        {
            //Arrange
            byte value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_short_sbyte_Success()
        {
            //Arrange
            short value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_byte_Success()
        {
            //Arrange
            short value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_short_Success()
        {
            //Arrange
            short value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_ushort_Success()
        {
            //Arrange
            short value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_int_Success()
        {
            //Arrange
            short value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_uint_Success()
        {
            //Arrange
            short value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_long_Success()
        {
            //Arrange
            short value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_ulong_Success()
        {
            //Arrange
            short value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_float_Success()
        {
            //Arrange
            short value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_double_Success()
        {
            //Arrange
            short value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_short_decimal_Success()
        {
            //Arrange
            short value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_ushort_sbyte_Success()
        {
            //Arrange
            ushort value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_byte_Success()
        {
            //Arrange
            ushort value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_short_Success()
        {
            //Arrange
            ushort value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_ushort_Success()
        {
            //Arrange
            ushort value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_int_Success()
        {
            //Arrange
            ushort value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_uint_Success()
        {
            //Arrange
            ushort value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_long_Success()
        {
            //Arrange
            ushort value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_ulong_Success()
        {
            //Arrange
            ushort value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_float_Success()
        {
            //Arrange
            ushort value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_double_Success()
        {
            //Arrange
            ushort value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ushort_decimal_Success()
        {
            //Arrange
            ushort value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_int_sbyte_Success()
        {
            //Arrange
            int value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_byte_Success()
        {
            //Arrange
            int value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_short_Success()
        {
            //Arrange
            int value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_ushort_Success()
        {
            //Arrange
            int value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_int_Success()
        {
            //Arrange
            int value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_uint_Success()
        {
            //Arrange
            int value = 5;
            int valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_long_Success()
        {
            //Arrange
            int value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_ulong_Success()
        {
            //Arrange
            int value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_float_Success()
        {
            //Arrange
            int value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_double_Success()
        {
            //Arrange
            int value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_int_decimal_Success()
        {
            //Arrange
            int value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_uint_sbyte_Success()
        {
            //Arrange
            uint value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_byte_Success()
        {
            //Arrange
            uint value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_short_Success()
        {
            //Arrange
            uint value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_ushort_Success()
        {
            //Arrange
            uint value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_int_Success()
        {
            //Arrange
            uint value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_uint_Success()
        {
            //Arrange
            uint value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_long_Success()
        {
            //Arrange
            uint value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_ulong_Success()
        {
            //Arrange
            uint value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_float_Success()
        {
            //Arrange
            uint value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_double_Success()
        {
            //Arrange
            uint value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_uint_decimal_Success()
        {
            //Arrange
            uint value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_long_sbyte_Success()
        {
            //Arrange
            long value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_byte_Success()
        {
            //Arrange
            long value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_short_Success()
        {
            //Arrange
            long value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_ushort_Success()
        {
            //Arrange
            long value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_int_Success()
        {
            //Arrange
            long value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_uint_Success()
        {
            //Arrange
            long value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_long_Success()
        {
            //Arrange
            long value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_ulong_Success()
        {
            //Arrange
            long value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_float_Success()
        {
            //Arrange
            long value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_double_Success()
        {
            //Arrange
            long value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_long_decimal_Success()
        {
            //Arrange
            long value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_ulong_sbyte_Success()
        {
            //Arrange
            ulong value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_byte_Success()
        {
            //Arrange
            ulong value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_short_Success()
        {
            //Arrange
            ulong value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_ushort_Success()
        {
            //Arrange
            ulong value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_int_Success()
        {
            //Arrange
            ulong value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_uint_Success()
        {
            //Arrange
            ulong value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_long_Success()
        {
            //Arrange
            ulong value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_ulong_Success()
        {
            //Arrange
            ulong value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_float_Success()
        {
            //Arrange
            ulong value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_double_Success()
        {
            //Arrange
            ulong value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_ulong_decimal_Success()
        {
            //Arrange
            ulong value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_float_sbyte_Success()
        {
            //Arrange
            float value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_byte_Success()
        {
            //Arrange
            float value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_short_Success()
        {
            //Arrange
            float value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_ushort_Success()
        {
            //Arrange
            float value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_int_Success()
        {
            //Arrange
            float value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_uint_Success()
        {
            //Arrange
            float value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_long_Success()
        {
            //Arrange
            float value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_ulong_Success()
        {
            //Arrange
            float value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_float_Success()
        {
            //Arrange
            float value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_double_Success()
        {
            //Arrange
            float value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_float_decimal_Success()
        {
            //Arrange
            float value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_double_sbyte_Success()
        {
            //Arrange
            double value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_byte_Success()
        {
            //Arrange
            double value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_short_Success()
        {
            //Arrange
            double value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_ushort_Success()
        {
            //Arrange
            double value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_int_Success()
        {
            //Arrange
            double value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_uint_Success()
        {
            //Arrange
            double value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_long_Success()
        {
            //Arrange
            double value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_ulong_Success()
        {
            //Arrange
            double value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_float_Success()
        {
            //Arrange
            double value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_double_Success()
        {
            //Arrange
            double value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_double_decimal_Success()
        {
            //Arrange
            double value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsLowerOrEqualsThan_decimal_sbyte_Success()
        {
            //Arrange
            decimal value = 5;
            sbyte valueLower = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_byte_Success()
        {
            //Arrange
            decimal value = 5;
            byte valueLower = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_short_Success()
        {
            //Arrange
            decimal value = 5;
            short valueLower = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_ushort_Success()
        {
            //Arrange
            decimal value = 5;
            ushort valueLower = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_int_Success()
        {
            //Arrange
            decimal value = 5;
            int valueLower = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_uint_Success()
        {
            //Arrange
            decimal value = 5;
            uint valueLower = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_long_Success()
        {
            //Arrange
            decimal value = 5;
            long valueLower = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_ulong_Success()
        {
            //Arrange
            decimal value = 5;
            ulong valueLower = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_float_Success()
        {
            //Arrange
            decimal value = 5;
            float valueLower = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_double_Success()
        {
            //Arrange
            decimal value = 5;
            double valueLower = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsLowerOrEqualsThan_decimal_decimal_Success()
        {
            //Arrange
            decimal value = 5;
            decimal valueLower = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsLowerOrEqualsThan(valueLower);
            var resultTrue1 = value.IsLowerOrEqualsThan(valueEqual);
            var resultTrue2 = value.IsLowerOrEqualsThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }
    }
}
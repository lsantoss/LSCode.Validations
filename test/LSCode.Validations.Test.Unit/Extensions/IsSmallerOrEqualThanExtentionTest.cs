using NUnit.Framework;
using System;
using LSCode.Validations.Extensions;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class IsSmallerOrEqualThanExtentionTest
    {
        [Test]
        public void IsSmallerOrEqualThan_sbyte_sbyte_Success()
        {
            //Arrange
            sbyte value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_byte_Success()
        {
            //Arrange
            sbyte value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_short_Success()
        {
            //Arrange
            sbyte value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_ushort_Success()
        {
            //Arrange
            sbyte value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_int_Success()
        {
            //Arrange
            sbyte value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_uint_Success()
        {
            //Arrange
            sbyte value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_long_Success()
        {
            //Arrange
            sbyte value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_ulong_Success()
        {
            //Arrange
            sbyte value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_float_Success()
        {
            //Arrange
            sbyte value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_double_Success()
        {
            //Arrange
            sbyte value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_sbyte_decimal_Success()
        {
            //Arrange
            sbyte value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_byte_sbyte_Success()
        {
            //Arrange
            byte value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_byte_Success()
        {
            //Arrange
            byte value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_short_Success()
        {
            //Arrange
            byte value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_ushort_Success()
        {
            //Arrange
            byte value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_int_Success()
        {
            //Arrange
            byte value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_uint_Success()
        {
            //Arrange
            byte value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_long_Success()
        {
            //Arrange
            byte value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_ulong_Success()
        {
            //Arrange
            byte value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_float_Success()
        {
            //Arrange
            byte value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_double_Success()
        {
            //Arrange
            byte value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_byte_decimal_Success()
        {
            //Arrange
            byte value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_short_sbyte_Success()
        {
            //Arrange
            short value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_byte_Success()
        {
            //Arrange
            short value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_short_Success()
        {
            //Arrange
            short value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_ushort_Success()
        {
            //Arrange
            short value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_int_Success()
        {
            //Arrange
            short value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_uint_Success()
        {
            //Arrange
            short value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_long_Success()
        {
            //Arrange
            short value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_ulong_Success()
        {
            //Arrange
            short value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_float_Success()
        {
            //Arrange
            short value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_double_Success()
        {
            //Arrange
            short value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_short_decimal_Success()
        {
            //Arrange
            short value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_ushort_sbyte_Success()
        {
            //Arrange
            ushort value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_byte_Success()
        {
            //Arrange
            ushort value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_short_Success()
        {
            //Arrange
            ushort value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_ushort_Success()
        {
            //Arrange
            ushort value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_int_Success()
        {
            //Arrange
            ushort value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_uint_Success()
        {
            //Arrange
            ushort value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_long_Success()
        {
            //Arrange
            ushort value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_ulong_Success()
        {
            //Arrange
            ushort value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_float_Success()
        {
            //Arrange
            ushort value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_double_Success()
        {
            //Arrange
            ushort value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ushort_decimal_Success()
        {
            //Arrange
            ushort value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_int_sbyte_Success()
        {
            //Arrange
            int value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_byte_Success()
        {
            //Arrange
            int value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_short_Success()
        {
            //Arrange
            int value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_ushort_Success()
        {
            //Arrange
            int value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_int_Success()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_uint_Success()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_long_Success()
        {
            //Arrange
            int value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_ulong_Success()
        {
            //Arrange
            int value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_float_Success()
        {
            //Arrange
            int value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_double_Success()
        {
            //Arrange
            int value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_int_decimal_Success()
        {
            //Arrange
            int value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_uint_sbyte_Success()
        {
            //Arrange
            uint value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_byte_Success()
        {
            //Arrange
            uint value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_short_Success()
        {
            //Arrange
            uint value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_ushort_Success()
        {
            //Arrange
            uint value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_int_Success()
        {
            //Arrange
            uint value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_uint_Success()
        {
            //Arrange
            uint value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_long_Success()
        {
            //Arrange
            uint value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_ulong_Success()
        {
            //Arrange
            uint value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_float_Success()
        {
            //Arrange
            uint value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_double_Success()
        {
            //Arrange
            uint value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_uint_decimal_Success()
        {
            //Arrange
            uint value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_long_sbyte_Success()
        {
            //Arrange
            long value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_byte_Success()
        {
            //Arrange
            long value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_short_Success()
        {
            //Arrange
            long value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_ushort_Success()
        {
            //Arrange
            long value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_int_Success()
        {
            //Arrange
            long value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_uint_Success()
        {
            //Arrange
            long value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_long_Success()
        {
            //Arrange
            long value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_ulong_Success()
        {
            //Arrange
            long value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_float_Success()
        {
            //Arrange
            long value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_double_Success()
        {
            //Arrange
            long value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_long_decimal_Success()
        {
            //Arrange
            long value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_ulong_sbyte_Success()
        {
            //Arrange
            ulong value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_byte_Success()
        {
            //Arrange
            ulong value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_short_Success()
        {
            //Arrange
            ulong value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_ushort_Success()
        {
            //Arrange
            ulong value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_int_Success()
        {
            //Arrange
            ulong value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_uint_Success()
        {
            //Arrange
            ulong value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_long_Success()
        {
            //Arrange
            ulong value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_ulong_Success()
        {
            //Arrange
            ulong value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_float_Success()
        {
            //Arrange
            ulong value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_double_Success()
        {
            //Arrange
            ulong value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_ulong_decimal_Success()
        {
            //Arrange
            ulong value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_float_sbyte_Success()
        {
            //Arrange
            float value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_byte_Success()
        {
            //Arrange
            float value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_short_Success()
        {
            //Arrange
            float value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_ushort_Success()
        {
            //Arrange
            float value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_int_Success()
        {
            //Arrange
            float value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_uint_Success()
        {
            //Arrange
            float value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_long_Success()
        {
            //Arrange
            float value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_ulong_Success()
        {
            //Arrange
            float value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_float_Success()
        {
            //Arrange
            float value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_double_Success()
        {
            //Arrange
            float value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_float_decimal_Success()
        {
            //Arrange
            float value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_double_sbyte_Success()
        {
            //Arrange
            double value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_byte_Success()
        {
            //Arrange
            double value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_short_Success()
        {
            //Arrange
            double value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_ushort_Success()
        {
            //Arrange
            double value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_int_Success()
        {
            //Arrange
            double value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_uint_Success()
        {
            //Arrange
            double value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_long_Success()
        {
            //Arrange
            double value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_ulong_Success()
        {
            //Arrange
            double value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_float_Success()
        {
            //Arrange
            double value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_double_Success()
        {
            //Arrange
            double value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_double_decimal_Success()
        {
            //Arrange
            double value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_decimal_sbyte_Success()
        {
            //Arrange
            decimal value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_byte_Success()
        {
            //Arrange
            decimal value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_short_Success()
        {
            //Arrange
            decimal value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_ushort_Success()
        {
            //Arrange
            decimal value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_int_Success()
        {
            //Arrange
            decimal value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_uint_Success()
        {
            //Arrange
            decimal value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_long_Success()
        {
            //Arrange
            decimal value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_ulong_Success()
        {
            //Arrange
            decimal value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_float_Success()
        {
            //Arrange
            decimal value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_double_Success()
        {
            //Arrange
            decimal value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }

        [Test]
        public void IsSmallerOrEqualThan_decimal_decimal_Success()
        {
            //Arrange
            decimal value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
            });
        }


        [Test]
        public void IsSmallerOrEqualThan_datetime_datetime_Success()
        {
            //Arrange
            DateTime value = new(2023, 2, 14);
            DateTime valueSmaller = new(2023, 2, 13);
            DateTime valueEqual = new(2023, 2, 14);
            DateTime valueGreater = new(2024, 3, 15);

            //Act
            var resultFalse = value.IsSmallerOrEqualThan(valueSmaller);
            var resultTrue1 = value.IsSmallerOrEqualThan(valueEqual);
            var resultTrue2 = value.IsSmallerOrEqualThan(valueGreater);

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
using NUnit.Framework;
using LSCode.Validations.Extensions;
using System;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class IsSmallerThanExtentionTest
    {
        [Test]
        public void IsSmallerThan_sbyte_sbyte_Success()
        {
            //Arrange
            sbyte value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_byte_Success()
        {
            //Arrange
            sbyte value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_short_Success()
        {
            //Arrange
            sbyte value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_ushort_Success()
        {
            //Arrange
            sbyte value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_int_Success()
        {
            //Arrange
            sbyte value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_uint_Success()
        {
            //Arrange
            sbyte value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_long_Success()
        {
            //Arrange
            sbyte value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_ulong_Success()
        {
            //Arrange
            sbyte value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_float_Success()
        {
            //Arrange
            sbyte value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_double_Success()
        {
            //Arrange
            sbyte value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_sbyte_decimal_Success()
        {
            //Arrange
            sbyte value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_byte_sbyte_Success()
        {
            //Arrange
            byte value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_byte_Success()
        {
            //Arrange
            byte value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_short_Success()
        {
            //Arrange
            byte value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_ushort_Success()
        {
            //Arrange
            byte value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_int_Success()
        {
            //Arrange
            byte value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_uint_Success()
        {
            //Arrange
            byte value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_long_Success()
        {
            //Arrange
            byte value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_ulong_Success()
        {
            //Arrange
            byte value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_float_Success()
        {
            //Arrange
            byte value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_double_Success()
        {
            //Arrange
            byte value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_byte_decimal_Success()
        {
            //Arrange
            byte value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_short_sbyte_Success()
        {
            //Arrange
            short value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_byte_Success()
        {
            //Arrange
            short value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_short_Success()
        {
            //Arrange
            short value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_ushort_Success()
        {
            //Arrange
            short value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_int_Success()
        {
            //Arrange
            short value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_uint_Success()
        {
            //Arrange
            short value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_long_Success()
        {
            //Arrange
            short value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_ulong_Success()
        {
            //Arrange
            short value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_float_Success()
        {
            //Arrange
            short value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_double_Success()
        {
            //Arrange
            short value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_short_decimal_Success()
        {
            //Arrange
            short value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_ushort_sbyte_Success()
        {
            //Arrange
            ushort value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_byte_Success()
        {
            //Arrange
            ushort value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_short_Success()
        {
            //Arrange
            ushort value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_ushort_Success()
        {
            //Arrange
            ushort value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_int_Success()
        {
            //Arrange
            ushort value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_uint_Success()
        {
            //Arrange
            ushort value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_long_Success()
        {
            //Arrange
            ushort value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_ulong_Success()
        {
            //Arrange
            ushort value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_float_Success()
        {
            //Arrange
            ushort value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_double_Success()
        {
            //Arrange
            ushort value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ushort_decimal_Success()
        {
            //Arrange
            ushort value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_int_sbyte_Success()
        {
            //Arrange
            int value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_byte_Success()
        {
            //Arrange
            int value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_short_Success()
        {
            //Arrange
            int value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_ushort_Success()
        {
            //Arrange
            int value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_int_Success()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_uint_Success()
        {
            //Arrange
            int value = 5;
            int valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_long_Success()
        {
            //Arrange
            int value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_ulong_Success()
        {
            //Arrange
            int value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_float_Success()
        {
            //Arrange
            int value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_double_Success()
        {
            //Arrange
            int value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_int_decimal_Success()
        {
            //Arrange
            int value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_uint_sbyte_Success()
        {
            //Arrange
            uint value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_byte_Success()
        {
            //Arrange
            uint value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_short_Success()
        {
            //Arrange
            uint value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_ushort_Success()
        {
            //Arrange
            uint value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_int_Success()
        {
            //Arrange
            uint value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_uint_Success()
        {
            //Arrange
            uint value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_long_Success()
        {
            //Arrange
            uint value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_ulong_Success()
        {
            //Arrange
            uint value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_float_Success()
        {
            //Arrange
            uint value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_double_Success()
        {
            //Arrange
            uint value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_uint_decimal_Success()
        {
            //Arrange
            uint value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_long_sbyte_Success()
        {
            //Arrange
            long value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_byte_Success()
        {
            //Arrange
            long value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_short_Success()
        {
            //Arrange
            long value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_ushort_Success()
        {
            //Arrange
            long value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_int_Success()
        {
            //Arrange
            long value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_uint_Success()
        {
            //Arrange
            long value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_long_Success()
        {
            //Arrange
            long value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_ulong_Success()
        {
            //Arrange
            long value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_float_Success()
        {
            //Arrange
            long value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_double_Success()
        {
            //Arrange
            long value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_long_decimal_Success()
        {
            //Arrange
            long value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_ulong_sbyte_Success()
        {
            //Arrange
            ulong value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_byte_Success()
        {
            //Arrange
            ulong value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_short_Success()
        {
            //Arrange
            ulong value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_ushort_Success()
        {
            //Arrange
            ulong value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_int_Success()
        {
            //Arrange
            ulong value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_uint_Success()
        {
            //Arrange
            ulong value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_long_Success()
        {
            //Arrange
            ulong value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_ulong_Success()
        {
            //Arrange
            ulong value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_float_Success()
        {
            //Arrange
            ulong value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_double_Success()
        {
            //Arrange
            ulong value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_ulong_decimal_Success()
        {
            //Arrange
            ulong value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_float_sbyte_Success()
        {
            //Arrange
            float value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_byte_Success()
        {
            //Arrange
            float value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_short_Success()
        {
            //Arrange
            float value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_ushort_Success()
        {
            //Arrange
            float value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_int_Success()
        {
            //Arrange
            float value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_uint_Success()
        {
            //Arrange
            float value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_long_Success()
        {
            //Arrange
            float value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_ulong_Success()
        {
            //Arrange
            float value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_float_Success()
        {
            //Arrange
            float value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_double_Success()
        {
            //Arrange
            float value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_float_decimal_Success()
        {
            //Arrange
            float value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_double_sbyte_Success()
        {
            //Arrange
            double value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_byte_Success()
        {
            //Arrange
            double value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_short_Success()
        {
            //Arrange
            double value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_ushort_Success()
        {
            //Arrange
            double value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_int_Success()
        {
            //Arrange
            double value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_uint_Success()
        {
            //Arrange
            double value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_long_Success()
        {
            //Arrange
            double value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_ulong_Success()
        {
            //Arrange
            double value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_float_Success()
        {
            //Arrange
            double value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_double_Success()
        {
            //Arrange
            double value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_double_decimal_Success()
        {
            //Arrange
            double value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_decimal_sbyte_Success()
        {
            //Arrange
            decimal value = 5;
            sbyte valueSmaller = 4;
            sbyte valueEqual = 5;
            sbyte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_byte_Success()
        {
            //Arrange
            decimal value = 5;
            byte valueSmaller = 4;
            byte valueEqual = 5;
            byte valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_short_Success()
        {
            //Arrange
            decimal value = 5;
            short valueSmaller = 4;
            short valueEqual = 5;
            short valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_ushort_Success()
        {
            //Arrange
            decimal value = 5;
            ushort valueSmaller = 4;
            ushort valueEqual = 5;
            ushort valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_int_Success()
        {
            //Arrange
            decimal value = 5;
            int valueSmaller = 4;
            int valueEqual = 5;
            int valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_uint_Success()
        {
            //Arrange
            decimal value = 5;
            uint valueSmaller = 4;
            uint valueEqual = 5;
            uint valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_long_Success()
        {
            //Arrange
            decimal value = 5;
            long valueSmaller = 4;
            long valueEqual = 5;
            long valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_ulong_Success()
        {
            //Arrange
            decimal value = 5;
            ulong valueSmaller = 4;
            ulong valueEqual = 5;
            ulong valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_float_Success()
        {
            //Arrange
            decimal value = 5;
            float valueSmaller = 4;
            float valueEqual = 5;
            float valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_double_Success()
        {
            //Arrange
            decimal value = 5;
            double valueSmaller = 4;
            double valueEqual = 5;
            double valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsSmallerThan_decimal_decimal_Success()
        {
            //Arrange
            decimal value = 5;
            decimal valueSmaller = 4;
            decimal valueEqual = 5;
            decimal valueGreater = 6;

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }


        [Test]
        public void IsSmallerThan_datetime_datetime_Success()
        {
            //Arrange
            DateTime value = new(2023, 2, 14);
            DateTime valueSmaller = new(2023, 2, 13);
            DateTime valueEqual = new(2023, 2, 14);
            DateTime valueGreater = new(2024, 3, 15);

            //Act
            var resultFalse1 = value.IsSmallerThan(valueSmaller);
            var resultFalse2 = value.IsSmallerThan(valueEqual);
            var resultTrue = value.IsSmallerThan(valueGreater);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }
    }
}
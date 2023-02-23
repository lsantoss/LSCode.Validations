using LSCode.Validations.SimpleValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.SimpleValidations.Extensions
{
    internal class DateTimeValidationExtensionTest
    {
        [Test]
        public void IsMaxValue_True_Success()
        {
            //Arrange
            var value = DateTime.MaxValue;

            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMaxValue_False_Success()
        {
            //Arrange
            var value = DateTime.UtcNow;

            //Act
            var result = value.IsMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMinValue_True_Success()
        {
            //Arrange
            var value = DateTime.MinValue;

            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMinValue_False_Success()
        {
            //Arrange
            var value = DateTime.UtcNow;

            //Act
            var result = value.IsMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotMaxValue_True_Success()
        {
            //Arrange
            var value = DateTime.UtcNow;

            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMaxValue_False_Success()
        {
            //Arrange
            var value = DateTime.MaxValue;

            //Act
            var result = value.IsNotMaxValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotMinValue_True_Success()
        {
            //Arrange
            var value = DateTime.UtcNow;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotMinValue_False_Success()
        {
            //Arrange
            var value = DateTime.MinValue;

            //Act
            var result = value.IsNotMinValue();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 18)]
        public void IsNotWeekday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWeekday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsNotWeekday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWeekday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsNotWeekend_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWeekend();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 18)]
        public void IsNotWeekend_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWeekend();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsWeekday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWeekday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 18)]
        public void IsWeekday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWeekday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 18)]
        public void IsWeekend_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWeekend();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsWeekend_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWeekend();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
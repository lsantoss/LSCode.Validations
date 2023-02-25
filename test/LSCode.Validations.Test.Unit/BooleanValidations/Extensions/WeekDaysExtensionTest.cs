using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class WeekDaysExtensionTest
    {
        [Test]
        [TestCase(2023, 02, 17)]
        public void IsFriday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsFriday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 18)]
        public void IsFriday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsFriday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        public void IsMonday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsMonday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsMonday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsMonday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 18)]
        public void IsNotFriday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotFriday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 17)]
        public void IsNotFriday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotFriday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsNotMonday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotMonday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        public void IsNotMonday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotMonday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsNotSaturday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotSaturday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 18)]
        public void IsNotSaturday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotSaturday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsNotSunday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotSunday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        public void IsNotSunday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotSunday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsNotThursday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotThursday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 16)]
        public void IsNotThursday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotThursday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsNotTuesday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotTuesday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 14)]
        public void IsNotTuesday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotTuesday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsNotWednesday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWednesday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 15)]
        public void IsNotWednesday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsNotWednesday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 18)]
        public void IsSaturday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsSaturday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        public void IsSaturday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsSaturday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        public void IsSunday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsSunday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsSunday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsSunday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 16)]
        public void IsThursday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsThursday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsThursday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsThursday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 14)]
        public void IsTuesday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsTuesday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 15)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsTuesday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsTuesday();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(2023, 02, 15)]
        public void IsWednesday_True_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWednesday();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2023, 02, 12)]
        [TestCase(2023, 02, 13)]
        [TestCase(2023, 02, 14)]
        [TestCase(2023, 02, 16)]
        [TestCase(2023, 02, 17)]
        [TestCase(2023, 02, 18)]
        public void IsWednesday_False_Success(int year, int month, int day)
        {
            //Arrange
            var date = new DateTime(year, month, day);

            //Act
            var result = date.IsWednesday();

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
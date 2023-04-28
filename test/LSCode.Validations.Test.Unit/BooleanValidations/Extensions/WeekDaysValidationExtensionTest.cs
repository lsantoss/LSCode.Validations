using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class WeekDaysValidationExtensionTest
    {
        [Test]
        [TestCase(2023, 02, 17)]
        public void IsFriday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsFriday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsMonday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsMonday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotFriday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotFriday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotMonday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotMonday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotSaturday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotSaturday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotSunday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotSunday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotThursday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotThursday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotTuesday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotTuesday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotWednesday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotWednesday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsSaturday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsSaturday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsSunday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsSunday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsThursday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsThursday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsTuesday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsTuesday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsWednesday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsWednesday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotWeekday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotWeekday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsNotWeekend_ShouldReturnTrue(int year, int month, int day)
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
        public void IsNotWeekend_ShouldReturnFalse(int year, int month, int day)
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
        public void IsWeekday_ShouldReturnTrue(int year, int month, int day)
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
        public void IsWeekday_ShouldReturnFalse(int year, int month, int day)
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
        public void IsWeekend_ShouldReturnTrue(int year, int month, int day)
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
        public void IsWeekend_ShouldReturnFalse(int year, int month, int day)
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
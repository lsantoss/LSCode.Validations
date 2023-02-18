using LSCode.Validations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class CalendarExtensionTest
    {
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
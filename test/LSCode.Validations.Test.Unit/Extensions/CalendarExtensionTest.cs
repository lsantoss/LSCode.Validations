using LSCode.Validations.Extensions;
using NUnit.Framework;
using System;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class CalendarExtensionTest
    {
        [Test]
        public void IsWeekday_Success()
        {
            //Arrange
            var dateSunday = new DateTime(2023, 02, 12);
            var dateMonday = new DateTime(2023, 02, 13);
            var dateTuesday = new DateTime(2023, 02, 14);
            var dateWednesday = new DateTime(2023, 02, 15);
            var dateThursday = new DateTime(2023, 02, 16);
            var dateFriday = new DateTime(2023, 02, 17);
            var dateSaturday = new DateTime(2023, 02, 18);

            //Act
            var resultSunday = dateSunday.IsWeekday();
            var resultMonday = dateMonday.IsWeekday();
            var resultTuesday = dateTuesday.IsWeekday();
            var resultWednesday = dateWednesday.IsWeekday();
            var resultThursday = dateThursday.IsWeekday();
            var resultFriday = dateFriday.IsWeekday();
            var resultSaturday = dateSaturday.IsWeekday();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultSunday, Is.False);
                Assert.That(resultMonday, Is.True);
                Assert.That(resultTuesday, Is.True);
                Assert.That(resultWednesday, Is.True);
                Assert.That(resultThursday, Is.True);
                Assert.That(resultFriday, Is.True);
                Assert.That(resultSaturday, Is.False);
            });
        }

        [Test]
        public void IsWeekend_Success()
        {
            //Arrange
            var dateSunday = new DateTime(2023, 02, 12);
            var dateMonday = new DateTime(2023, 02, 13);
            var dateTuesday = new DateTime(2023, 02, 14);
            var dateWednesday = new DateTime(2023, 02, 15);
            var dateThursday = new DateTime(2023, 02, 16);
            var dateFriday = new DateTime(2023, 02, 17);
            var dateSaturday = new DateTime(2023, 02, 18);

            //Act
            var resultSunday = dateSunday.IsWeekend();
            var resultMonday = dateMonday.IsWeekend();
            var resultTuesday = dateTuesday.IsWeekend();
            var resultWednesday = dateWednesday.IsWeekend();
            var resultThursday = dateThursday.IsWeekend();
            var resultFriday = dateFriday.IsWeekend();
            var resultSaturday = dateSaturday.IsWeekend();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultSaturday, Is.True);
                Assert.That(resultMonday, Is.False);
                Assert.That(resultTuesday, Is.False);
                Assert.That(resultWednesday, Is.False);
                Assert.That(resultThursday, Is.False);
                Assert.That(resultFriday, Is.False);
                Assert.That(resultSaturday, Is.True);
            });
        }
    }
}
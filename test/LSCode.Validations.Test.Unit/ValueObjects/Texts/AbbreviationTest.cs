using LSCode.Validations.ValueObjects.Texts;
using NUnit.Framework;
using System.Linq;

namespace LSCode.Validations.Test.Unit.ValueObjects.Texts
{
    internal class AbbreviationTest
    {
        [Test]
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aa")]
        [TestCase("A")]
        [TestCase("AA")]
        [TestCase("aA5")]
        [TestCase("a55")]
        [TestCase("555")]
        public void Constructor_Valid_Success(string value)
        {
            //Act
            var valueObject = new Abbreviation(value);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(valueObject.Value, Is.EqualTo(value));
                Assert.That(valueObject.Valid, Is.True);
                Assert.That(valueObject.Invalid, Is.False);
                Assert.That(valueObject.Notifications, Is.Empty);
            });
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void Constructor_Without_Content_Invalid_Success(string value)
        {
            //Act
            var valueObject = new Abbreviation(value);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(valueObject.Value, Is.EqualTo(value));
                Assert.That(valueObject.Valid, Is.False);
                Assert.That(valueObject.Invalid, Is.True);
                Assert.That(valueObject.Notifications, Has.Count.EqualTo(1));
                Assert.That(valueObject.Notifications.ToList()[0].Property, Is.EqualTo("Abbreviation"));
                Assert.That(valueObject.Notifications.ToList()[0].Message, Is.EqualTo("Abbreviation cannot be null, empty or white espaces"));
            });
        }

        [Test]
        [TestCase("aaaaaa")]
        [TestCase("aaaAAAAA")]
        [TestCase("AAAA")]
        [TestCase("a55AAA")]
        [TestCase("555555")]
        public void Constructor_String_With_More_Than_Three_Characters_Invalid_Success(string value)
        {
            //Act
            var valueObject = new Abbreviation(value);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(valueObject.Value, Is.EqualTo(value));
                Assert.That(valueObject.Valid, Is.False);
                Assert.That(valueObject.Invalid, Is.True);
                Assert.That(valueObject.Notifications, Has.Count.EqualTo(1));
                Assert.That(valueObject.Notifications.ToList()[0].Property, Is.EqualTo("Abbreviation"));
                Assert.That(valueObject.Notifications.ToList()[0].Message, Is.EqualTo("Abbreviation greater than 3 characters"));
            });
        }
    }
}
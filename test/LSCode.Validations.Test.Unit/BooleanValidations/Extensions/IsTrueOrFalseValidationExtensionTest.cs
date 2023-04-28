using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsTrueOrFalseValidationExtensionTest
    {
        [Test]
        [TestCase(false)]
        public void IsFalse_ShouldReturnTrue(bool value)
        {
            //Act
            var result = value.IsFalse();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        public void IsFalse_ShouldReturnFalse(bool value)
        {
            //Act
            var result = value.IsFalse();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        public void IsTrue_ShouldReturnTrue(bool value)
        {
            //Act
            var result = value.IsTrue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(false)]
        public void IsTrue_ShouldReturnFalse(bool value)
        {
            //Act
            var result = value.IsTrue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
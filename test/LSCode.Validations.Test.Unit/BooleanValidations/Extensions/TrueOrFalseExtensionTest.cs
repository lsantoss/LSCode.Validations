using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class TrueOrFalseExtensionTest
    {
        [Test]
        [TestCase(false)]
        public void IsFalse_True_Success(bool value)
        {
            //Act
            var result = value.IsFalse();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        public void IsFalse_False_Success(bool value)
        {
            //Act
            var result = value.IsFalse();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        public void IsTrue_True_Success(bool value)
        {
            //Act
            var result = value.IsTrue();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(false)]
        public void IsTrue_False_Success(bool value)
        {
            //Act
            var result = value.IsTrue();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}

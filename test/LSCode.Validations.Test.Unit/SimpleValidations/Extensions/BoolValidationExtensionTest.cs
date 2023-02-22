using LSCode.Validations.SimpleValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.SimpleValidations.Extensions
{
    internal class BoolValidationExtensionTest
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
        [TestCase(null)]
        public void IsNull_True_Success(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNull_False_Success(bool? value)
        {
            //Act
            var result = value.IsNull();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IsNotNull_True_Success(bool? value)
        {
            //Act
            var result = value.IsNotNull();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(null)]
        public void IsNotNull_False_Success(bool? value)
        {
            //Act
            var result = value.IsNotNull();

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

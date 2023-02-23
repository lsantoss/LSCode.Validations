using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsNotNullExtensionTest
    {
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
    }
}
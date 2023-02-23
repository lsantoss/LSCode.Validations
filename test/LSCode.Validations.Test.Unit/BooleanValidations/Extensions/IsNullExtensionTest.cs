using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsNullExtensionTest
    {
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
    }
}
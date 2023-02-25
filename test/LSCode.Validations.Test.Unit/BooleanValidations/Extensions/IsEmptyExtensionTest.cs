using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class IsEmptyExtensionTest
    {
        [Test]
        [TestCase("")]
        public void IsEmpty_string_True_Success(string value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("aaa")]
        [TestCase("aaa aaa")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsEmpty_sbyte_False_Success(string value)
        {
            //Act
            var result = value.IsEmpty();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
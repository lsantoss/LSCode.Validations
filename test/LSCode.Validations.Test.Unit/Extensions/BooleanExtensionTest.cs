using NUnit.Framework;
using LSCode.Validations.Extensions;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class BooleanExtensionTest
    {
        [Test]
        public void IsFalse_Success()
        {
            //Arrange
            var valueFalse = false;
            var valueTrue = true;

            //Act
            var resultFalse = valueTrue.IsFalse();
            var resultTrue = valueFalse.IsFalse();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }

        [Test]
        public void IsTrue_Success()
        {
            //Arrange
            var valueFalse = false;
            var valueTrue = true;

            //Act
            var resultFalse = valueFalse.IsTrue();
            var resultTrue = valueTrue.IsTrue();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultFalse, Is.False);
                Assert.That(resultTrue, Is.True);
            });
        }
    }
}
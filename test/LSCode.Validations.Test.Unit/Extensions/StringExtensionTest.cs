using NUnit.Framework;
using LSCode.Validations.Extensions;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class StringExtensionTest
    {
        [Test]
        public void IsNull_Success()
        {
            //Arrange
            string valueTrue1 = null;
            int? valueTrue2 = null;
            var valueFalse1 = false;
            var valueFalse2 = 1;
            var valueFalse3 = "test";
            var valueFalse4 = new { reason = "test" };

            //Act
            var resultTrue1 = valueTrue1.IsNull();
            var resultTrue2 = valueTrue2.IsNull();
            var resultFalse1 = valueFalse1.IsNull();
            var resultFalse2 = valueFalse2.IsNull();
            var resultFalse3 = valueFalse3.IsNull();
            var resultFalse4 = valueFalse4.IsNull();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultFalse3, Is.False);
                Assert.That(resultFalse4, Is.False);
            });
        }

        [Test]
        public void IsNullOrEmpty_Success()
        {
            //Arrange
            string valueTrue1 = null;
            var valueTrue2 = "";
            var valueFalse1 = " ";
            var valueFalse2 = "test";

            //Act
            var resultTrue1 = valueTrue1.IsNullOrEmpty();
            var resultTrue2 = valueTrue2.IsNullOrEmpty();
            var resultFalse1 = valueFalse1.IsNullOrEmpty();
            var resultFalse2 = valueFalse2.IsNullOrEmpty();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
            });
        }

        [Test]
        public void IsNullOrEmptyOrWhiteSpace_Success()
        {
            //Arrange
            string valueTrue1 = null;
            var valueTrue2 = "";
            var valueTrue3 = " ";
            var valueFalse2 = "test";

            //Act
            var resultTrue1 = valueTrue1.IsNullOrEmptyOrWhiteSpace();
            var resultTrue2 = valueTrue2.IsNullOrEmptyOrWhiteSpace();
            var resultTrue3 = valueTrue3.IsNullOrEmptyOrWhiteSpace();
            var resultFalse2 = valueFalse2.IsNullOrEmptyOrWhiteSpace();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultTrue3, Is.True);
                Assert.That(resultFalse2, Is.False);
            });
        }
    }
}
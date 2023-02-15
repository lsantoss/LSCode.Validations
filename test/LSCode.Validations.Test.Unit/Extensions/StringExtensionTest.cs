using LSCode.Validations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.Extensions
{
    internal class StringExtensionTest
    {
        [Test]
        public void ContainsText_Success()
        {
            //Arrange
            var value = "Text cannot be null or empty";
            var valueTrue1 = "Text";
            var valueTrue2 = "cannot";
            var valueTrue3 = "be";
            var valueTrue4 = "null";
            var valueTrue5 = "or";
            var valueTrue6 = "empty";
            var valueTrue7 = " ";
            var valueTrue8 = "can";
            var valueFalse1 = "house";
            var valueFalse2 = "home";
            var valueFalse3 = "site";
            var valueFalse4 = "car";

            //Act
            var resultTrue1 = value.ContainsText(valueTrue1);
            var resultTrue2 = value.ContainsText(valueTrue2);
            var resultTrue3 = value.ContainsText(valueTrue3);
            var resultTrue4 = value.ContainsText(valueTrue4);
            var resultTrue5 = value.ContainsText(valueTrue5);
            var resultTrue6 = value.ContainsText(valueTrue6);
            var resultTrue7 = value.ContainsText(valueTrue7);
            var resultTrue8 = value.ContainsText(valueTrue8);
            var resultFalse1 = value.ContainsText(valueFalse1);
            var resultFalse2 = value.ContainsText(valueFalse2);
            var resultFalse3 = value.ContainsText(valueFalse3);
            var resultFalse4 = value.ContainsText(valueFalse4);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue1, Is.True);
                Assert.That(resultTrue2, Is.True);
                Assert.That(resultTrue3, Is.True);
                Assert.That(resultTrue4, Is.True);
                Assert.That(resultTrue5, Is.True);
                Assert.That(resultTrue6, Is.True);
                Assert.That(resultTrue7, Is.True);
                Assert.That(resultTrue8, Is.True);
                Assert.That(resultFalse1, Is.False);
                Assert.That(resultFalse2, Is.False);
                Assert.That(resultFalse3, Is.False);
                Assert.That(resultFalse4, Is.False);
            });
        }

        [Test]
        public void HasDifferentLengthThan_Success()
        {
            //Arrange
            var value = "Text cannot be null or empty";
            var valueTrue = 13;
            var valueFalse = 28;

            //Act
            var resultTrue = value.HasDifferentLengthThan(valueTrue);
            var resultFalse = value.HasDifferentLengthThan(valueFalse);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

        [Test]
        public void HasEqualLengthThan_Success()
        {
            //Arrange
            var value = "Text cannot be null or empty";
            var valueTrue = 28;
            var valueFalse = 13;

            //Act
            var resultTrue = value.HasEqualLengthThan(valueTrue);
            var resultFalse = value.HasEqualLengthThan(valueFalse);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(resultTrue, Is.True);
                Assert.That(resultFalse, Is.False);
            });
        }

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
using NUnit.Framework;
using LSCode.Validations.BooleanValidations.Extensions;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class AdressesExtensionTest
    {
        [Test]
        [TestCase("68980-970")]
        [TestCase("68980970")]
        [TestCase("35150-970")]
        [TestCase("35150970")]
        [TestCase("56360-970")]
        [TestCase("56360970")]
        public void IsCEP_True_Success(string value)
        {
            //Act
            var result = value.IsCEP();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("68980-97")]
        [TestCase("6898097")]
        [TestCase("3515-970")]
        [TestCase("3515970")]
        [TestCase("5-6360970")]
        [TestCase("56-360970")]
        [TestCase("563-60970")]
        [TestCase("5636-0970")]
        [TestCase("563609-70")]
        [TestCase("5636097-0")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsCEP_False_Success(string value)
        {
            //Act
            var result = value.IsCEP();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
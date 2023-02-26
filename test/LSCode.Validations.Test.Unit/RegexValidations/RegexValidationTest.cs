using LSCode.Validations.RegexValidations;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.RegexValidations
{
    internal class RegexValidationTest
    {
        [Test]
        [TestCase("68980-970", @"^\d{5}\-?\d{3}$")]
        [TestCase("68980970",  @"^\d{5}\-?\d{3}$")]
        [TestCase("35150-970", @"^\d{5}\-?\d{3}$")]
        [TestCase("35150970",  @"^\d{5}\-?\d{3}$")]
        [TestCase("56360-970", @"^\d{5}\-?\d{3}$")]
        [TestCase("56360970",  @"^\d{5}\-?\d{3}$")]
        public void IsMatch_True_Success(string value, string pattern)
        {
            //Act
            var result = RegexValidation.IsMatch(value, pattern);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("68980-97",  @"^\d{5}\-?\d{3}$")]
        [TestCase("6898097",   @"^\d{5}\-?\d{3}$")]
        [TestCase("3515-970",  @"^\d{5}\-?\d{3}$")]
        [TestCase("3515970",   @"^\d{5}\-?\d{3}$")]
        [TestCase("5-6360970", @"^\d{5}\-?\d{3}$")]
        [TestCase("56-360970", @"^\d{5}\-?\d{3}$")]
        [TestCase("563-60970", @"^\d{5}\-?\d{3}$")]
        [TestCase("5636-0970", @"^\d{5}\-?\d{3}$")]
        [TestCase("563609-70", @"^\d{5}\-?\d{3}$")]
        [TestCase("5636097-0", @"^\d{5}\-?\d{3}$")]
        [TestCase("",          @"^\d{5}\-?\d{3}$")]
        [TestCase(" ",         @"^\d{5}\-?\d{3}$")]
        [TestCase(null,        @"^\d{5}\-?\d{3}$")]
        public void IsMatch_False_Success(string value, string pattern)
        {
            //Act
            var result = RegexValidation.IsMatch(value, pattern);

            //Assert
            Assert.That(result, Is.False);
        }
    }
}

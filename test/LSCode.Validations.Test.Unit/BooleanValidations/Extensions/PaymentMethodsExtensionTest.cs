using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class PaymentMethodsExtensionTest
    {
        [Test]
        [TestCase("5181 0310 8360 9300")]
        [TestCase("5181031083609300")]
        [TestCase("4485 2204 9403 9951")]
        [TestCase("4485220494039951")]
        [TestCase("3713 371608 73151")]
        [TestCase("371337160873151")]
        [TestCase("3025 085154 4218")]
        [TestCase("30250851544218")]
        [TestCase("6011 1066 5275 9324")]
        [TestCase("6011106652759324")]
        [TestCase("2149 3089159 6553")]
        [TestCase("214930891596553")]
        [TestCase("3557 9870 2790 2591")]
        [TestCase("3557987027902591")]
        [TestCase("86998 5731 23703 0")]
        [TestCase("869985731237030")]
        [TestCase("6062 8213 0945 3232")]
        [TestCase("6062821309453232")]
        [TestCase("5017 7540 4997 3656")]
        [TestCase("5017754049973656")]
        public void IsCreditCard_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsCreditCard();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5181 1310 8160 9100")]
        [TestCase("5181131081609100")]
        [TestCase("4485 2204 9603 6651")]
        [TestCase("4485220496036651")]
        [TestCase("3713 371208 73151")]
        [TestCase("371337120873151")]
        [TestCase("3015 085884 4218")]
        [TestCase("30150858844218")]
        [TestCase("6017 1066 5475 9424")]
        [TestCase("6017106654759424")]
        [TestCase("2219 3085759 6553")]
        [TestCase("221930857596553")]
        [TestCase("3557 9870 2790 2578")]
        [TestCase("3557987027902578")]
        [TestCase("86777 5731 45703 0")]
        [TestCase("867775731457030")]
        [TestCase("6111 1113 0855 2132")]
        [TestCase("6111111308552132")]
        [TestCase("5010 7500 1297 3656")]
        [TestCase("5010750012973656")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsCreditCard_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsCreditCard();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
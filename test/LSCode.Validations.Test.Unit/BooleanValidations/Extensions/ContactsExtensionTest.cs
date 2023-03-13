using NUnit.Framework;
using LSCode.Validations.BooleanValidations.Extensions;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class ContactsExtensionTest
    {
        [Test]
        [TestCase("5511944445555")]
        [TestCase("5512944445555")]
        [TestCase("5513944445555")]
        [TestCase("5514944445555")]
        [TestCase("5515944445555")]
        [TestCase("5516944445555")]
        [TestCase("5517944445555")]
        [TestCase("5518944445555")]
        [TestCase("5519944445555")]
        [TestCase("5521944445555")]
        [TestCase("5522944445555")]
        [TestCase("5524944445555")]
        [TestCase("5527944445555")]
        [TestCase("5528944445555")]
        [TestCase("5531944445555")]
        [TestCase("5532944445555")]
        [TestCase("5533944445555")]
        [TestCase("5534944445555")]
        [TestCase("5535944445555")]
        [TestCase("5537944445555")]
        [TestCase("5538944445555")]
        [TestCase("5541944445555")]
        [TestCase("5542944445555")]
        [TestCase("5543944445555")]
        [TestCase("5544944445555")]
        [TestCase("5545944445555")]
        [TestCase("5546944445555")]
        [TestCase("5547944445555")]
        [TestCase("5546944445555")]
        [TestCase("5547944445555")]
        [TestCase("5548944445555")]
        [TestCase("5549944445555")]
        [TestCase("5551944445555")]
        [TestCase("5553944445555")]
        [TestCase("5554944445555")]
        [TestCase("5555944445555")]
        [TestCase("5561944445555")]
        [TestCase("5562944445555")]
        [TestCase("5563944445555")]
        [TestCase("5564944445555")]
        [TestCase("5565944445555")]
        [TestCase("5566944445555")]
        [TestCase("5567944445555")]
        [TestCase("5568944445555")]
        [TestCase("5569944445555")]
        [TestCase("5571944445555")]
        [TestCase("5573944445555")]
        [TestCase("5574944445555")]
        [TestCase("5575944445555")]
        [TestCase("5577944445555")]
        [TestCase("5579944445555")]
        [TestCase("5581944445555")]
        [TestCase("5582944445555")]
        [TestCase("5583944445555")]
        [TestCase("5584944445555")]
        [TestCase("5585944445555")]
        [TestCase("5586944445555")]
        [TestCase("5587944445555")]
        [TestCase("5588944445555")]
        [TestCase("5589944445555")]
        [TestCase("5591944445555")]
        [TestCase("5592944445555")]
        [TestCase("5593944445555")]
        [TestCase("5594944445555")]
        [TestCase("5595944445555")]
        [TestCase("5596944445555")]
        [TestCase("5597944445555")]
        [TestCase("5598944445555")]
        [TestCase("5599944445555")]
        public void IsBrazilianCellphone_True_Success(string value)
        {
            //Act
            var result = value.IsBrazilianCellphone();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5")] //Validation - Strings shorter than expected
        [TestCase("55")]
        [TestCase("555")]
        [TestCase("5555")]
        [TestCase("45555")]
        [TestCase("445555")]
        [TestCase("4445555")]
        [TestCase("44445555")]
        [TestCase("944445555")]
        [TestCase("6944445555")]
        [TestCase("66944445555")]
        [TestCase("566944445555")]
        [TestCase("5501944445555")] //Validation - DDD
        [TestCase("5502944445555")]
        [TestCase("5503944445555")]
        [TestCase("5504944445555")]
        [TestCase("5505944445555")]
        [TestCase("5506944445555")]
        [TestCase("5507944445555")]
        [TestCase("5508944445555")]
        [TestCase("5509944445555")]
        [TestCase("5510944445555")]
        [TestCase("5520944445555")]
        [TestCase("5523944445555")]
        [TestCase("5525944445555")]
        [TestCase("5526944445555")]
        [TestCase("5529944445555")]
        [TestCase("5536944445555")]
        [TestCase("5539944445555")]
        [TestCase("5540944445555")]
        [TestCase("5550944445555")]
        [TestCase("5552944445555")]
        [TestCase("5556944445555")]
        [TestCase("5557944445555")]
        [TestCase("5558944445555")]
        [TestCase("5559944445555")]
        [TestCase("5560944445555")]
        [TestCase("5570944445555")]
        [TestCase("5572944445555")]
        [TestCase("5576944445555")]
        [TestCase("5580944445555")]
        [TestCase("5590944445555")]
        [TestCase("0166944445555")] //Validation - DDI
        [TestCase("5566044445555")] //Validation - Position 4 - Number 9
        [TestCase("5566144445555")]
        [TestCase("5566244445555")]
        [TestCase("5566344445555")]
        [TestCase("5566444445555")]
        [TestCase("5566544445555")]
        [TestCase("5566644445555")]
        [TestCase("5566744445555")]
        [TestCase("5566844445555")]
        [TestCase("5566904445555")] //Validation - Position 5 - Number from 1 to 9
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsBrazilianCellphone_False_Success(string value)
        {
            //Act
            var result = value.IsBrazilianCellphone();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("551144445555")]
        [TestCase("551244445555")]
        [TestCase("551344445555")]
        [TestCase("551444445555")]
        [TestCase("551544445555")]
        [TestCase("551644445555")]
        [TestCase("551744445555")]
        [TestCase("551844445555")]
        [TestCase("551944445555")]
        [TestCase("552144445555")]
        [TestCase("552244445555")]
        [TestCase("552444445555")]
        [TestCase("552744445555")]
        [TestCase("552844445555")]
        [TestCase("553144445555")]
        [TestCase("553244445555")]
        [TestCase("553344445555")]
        [TestCase("553444445555")]
        [TestCase("553544445555")]
        [TestCase("553744445555")]
        [TestCase("553844445555")]
        [TestCase("554144445555")]
        [TestCase("554244445555")]
        [TestCase("554344445555")]
        [TestCase("554444445555")]
        [TestCase("554544445555")]
        [TestCase("554644445555")]
        [TestCase("554744445555")]
        [TestCase("554644445555")]
        [TestCase("554744445555")]
        [TestCase("554844445555")]
        [TestCase("554944445555")]
        [TestCase("555144445555")]
        [TestCase("555344445555")]
        [TestCase("555444445555")]
        [TestCase("555544445555")]
        [TestCase("556144445555")]
        [TestCase("556244445555")]
        [TestCase("556344445555")]
        [TestCase("556444445555")]
        [TestCase("556544445555")]
        [TestCase("556644445555")]
        [TestCase("556744445555")]
        [TestCase("556844445555")]
        [TestCase("556944445555")]
        [TestCase("557144445555")]
        [TestCase("557344445555")]
        [TestCase("557444445555")]
        [TestCase("557544445555")]
        [TestCase("557744445555")]
        [TestCase("557944445555")]
        [TestCase("558144445555")]
        [TestCase("558244445555")]
        [TestCase("558344445555")]
        [TestCase("558444445555")]
        [TestCase("558544445555")]
        [TestCase("558644445555")]
        [TestCase("558744445555")]
        [TestCase("558844445555")]
        [TestCase("558944445555")]
        [TestCase("559144445555")]
        [TestCase("559244445555")]
        [TestCase("559344445555")]
        [TestCase("559444445555")]
        [TestCase("559544445555")]
        [TestCase("559644445555")]
        [TestCase("559744445555")]
        [TestCase("559844445555")]
        [TestCase("559944445555")]
        public void IsBrazilianTelephone_True_Success(string value)
        {
            //Act
            var result = value.IsBrazilianTelephone();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5")] //Validation - Strings shorter than expected
        [TestCase("55")]
        [TestCase("555")]
        [TestCase("5555")]
        [TestCase("45555")]
        [TestCase("445555")]
        [TestCase("4445555")]
        [TestCase("44445555")]
        [TestCase("44445555")]
        [TestCase("644445555")]
        [TestCase("6644445555")]
        [TestCase("56644445555")]
        [TestCase("550144445555")] //Validation - DDD
        [TestCase("550244445555")]
        [TestCase("550344445555")]
        [TestCase("550444445555")]
        [TestCase("550544445555")]
        [TestCase("550644445555")]
        [TestCase("550744445555")]
        [TestCase("550844445555")]
        [TestCase("550944445555")]
        [TestCase("551044445555")]
        [TestCase("552044445555")]
        [TestCase("552344445555")]
        [TestCase("552544445555")]
        [TestCase("552644445555")]
        [TestCase("552944445555")]
        [TestCase("553644445555")]
        [TestCase("553944445555")]
        [TestCase("554044445555")]
        [TestCase("555044445555")]
        [TestCase("555244445555")]
        [TestCase("555644445555")]
        [TestCase("555744445555")]
        [TestCase("555844445555")]
        [TestCase("555944445555")]
        [TestCase("556044445555")]
        [TestCase("557044445555")]
        [TestCase("557244445555")]
        [TestCase("557644445555")]
        [TestCase("558044445555")]
        [TestCase("559044445555")]
        [TestCase("016644445555")] //Validation - DDI
        [TestCase("556604445555")] //Validation - Position 4 - Number from 2 to 8
        [TestCase("556614445555")]
        [TestCase("556694445555")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsBrazilianTelephone_False_Success(string value)
        {
            //Act
            var result = value.IsBrazilianTelephone();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("myemail@hotmail.com")]
        [TestCase("myemail@hotmail.com.br")]
        [TestCase("myemail123@hotmail.com.br")]
        [TestCase("myemail@hotmail.net")]
        public void IsEmail_True_Success(string value)
        {
            //Act
            var result = value.IsEmail();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Test if it's a email")]
        [TestCase("myemailhotmail.com")]
        [TestCase("myemailhotmail.com.br")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsEmail_False_Success(string value)
        {
            //Act
            var result = value.IsEmail();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
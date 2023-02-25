using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    internal class StringExtensionTest
    {
        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("House")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsCapitalLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsCapitalLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555 e")]
        [TestCase("$#%& e")]
        [TestCase("5555$#%&e")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsCapitalLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsCapitalLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("tests")]
        [TestCase("tests55")]
        [TestCase("tests 55")]
        [TestCase("House 55 **")]
        public void ContainsLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555")]
        [TestCase("$#%&")]
        [TestCase("5555$#%&")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("House")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsLowercaseLetter_True_Success(string value)
        {
            //Act
            var result = value.ContainsLowercaseLetter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5555 E")]
        [TestCase("$#%& E")]
        [TestCase("5555$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsLowercaseLetter_False_Success(string value)
        {
            //Act
            var result = value.ContainsLowercaseLetter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty 5")]
        [TestCase("House5")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("House 55 **")]
        public void ContainsNumber_True_Success(string value)
        {
            //Act
            var result = value.ContainsNumber();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("aaaa E")]
        [TestCase("$#%& E")]
        [TestCase("aaaa$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsNumber_False_Success(string value)
        {
            //Act
            var result = value.ContainsNumber();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("A")]
        [TestCase("AA")]
        [TestCase("AAA")]
        [TestCase("AAAA")]
        public void ContainsOnlyCapitalLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyCapitalLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aA")]
        [TestCase("5555")]
        [TestCase("aa555##")]
        [TestCase("AA555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyCapitalLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyCapitalLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("a")]
        [TestCase("A")]
        [TestCase("aAaA")]
        [TestCase("AAaAaaA")]
        public void ContainsOnlyLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("5")]
        [TestCase("55 ##")]
        [TestCase("555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aaa")]
        [TestCase("aaaa")]
        public void ContainsOnlyLowercaseLetters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLowercaseLetters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("A")]
        [TestCase("aA")]
        [TestCase("5555")]
        [TestCase("aa555##")]
        [TestCase("AA555##")]
        [TestCase("5555##55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyLowercaseLetters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyLowercaseLetters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("5")]
        [TestCase("55")]
        [TestCase("555")]
        [TestCase("5555")]
        public void ContainsOnlyNumbers_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyNumbers();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("4 ")]
        [TestCase("4 E")]
        [TestCase("aaaa E")]
        [TestCase("aaaa55E")]
        [TestCase("$#%& E5")]
        [TestCase("5aaaa$#%&E")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlyNumbers_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlyNumbers();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("&&")]
        [TestCase("$#%&")]
        [TestCase("!!!$#%&%&")]
        public void ContainsOnlySpecialCharacters_True_Success(string value)
        {
            //Act
            var result = value.ContainsOnlySpecialCharacters();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("#$ ")]
        [TestCase("#$ ##")]
        [TestCase("#$ 55")]
        [TestCase("Text cannot be null #")]
        [TestCase("House5#")]
        [TestCase("houSe55$%$@@")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsOnlySpecialCharacters_False_Success(string value)
        {
            //Act
            var result = value.ContainsOnlySpecialCharacters();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("5555 aa e &&")]
        [TestCase("$#%& e")]
        [TestCase("5555$#%&e")]
        [TestCase("tests 5555 $#%& e")]
        public void ContainsSpecialCharacter_True_Success(string value)
        {
            //Act
            var result = value.ContainsSpecialCharacter();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty 5")]
        [TestCase("House5")]
        [TestCase("houSe55")]
        [TestCase("housE 55")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ContainsSpecialCharacter_False_Success(string value)
        {
            //Act
            var result = value.ContainsSpecialCharacter();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", "Text")]
        [TestCase("Text cannot be null or empty", "cannot")]
        [TestCase("Text cannot be null or empty", "be")]
        [TestCase("Text cannot be null or empty", "null")]
        [TestCase("Text cannot be null or empty", "or")]
        [TestCase("Text cannot be null or empty", "empty")]
        [TestCase("Text cannot be null or empty", "can")]
        [TestCase("Text cannot be null or empty", " ")]
        public void ContainsText_True_Success(string value, string text)
        {
            //Act
            var result = value.ContainsText(text);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", "tests")]
        [TestCase("Text cannot be null or empty", "home")]
        [TestCase("Text cannot be null or empty", "site")]
        [TestCase("Text cannot be null or empty", "car")]
        [TestCase("Text cannot be null or empty", "")]
        [TestCase("Text cannot be null or empty", null)]
        [TestCase(null, "tests")]
        [TestCase(null, null)]
        public void ContainsText_False_Success(string value, string text)
        {
            //Act
            var result = value.ContainsText(text);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 12)]
        [TestCase("tests", 10)]
        public void HasDifferentLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasDifferentLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 5)]
        [TestCase(null, 10)]
        public void HasDifferentLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasDifferentLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 5)]
        public void HasEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 12)]
        [TestCase("tests", 10)]
        [TestCase(null, 10)]
        public void HasEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        public void HasGreaterLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasGreaterLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 4)]
        [TestCase("tests", 5)]
        public void HasGreaterOrEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 6)]
        [TestCase(null, 10)]
        public void HasGreaterOrEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasGreaterOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 6)]
        public void HasSmallerLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("tests", 4)]
        [TestCase("tests", 5)]
        [TestCase(null, 10)]
        public void HasSmallerLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 28)]
        [TestCase("Text cannot be null or empty", 29)]
        [TestCase("tests", 5)]
        [TestCase("tests", 6)]
        public void HasSmallerOrEqualLengthThan_True_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty", 27)]
        [TestCase("tests", 4)]
        [TestCase(null, 10)]
        public void HasSmallerOrEqualLengthThan_False_Success(string value, int length)
        {
            //Act
            var result = value.HasSmallerOrEqualLengthThan(length);

            //Assert
            Assert.That(result, Is.False);
        }

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

        [Test]
        [TestCase("860.432.350-30")]
        [TestCase("86043235030")]
        [TestCase("538.966.330-66")]
        [TestCase("53896633066")]
        [TestCase("776.442.100-67")]
        [TestCase("77644210067")]
        public void IsCPF_True_Success(string value)
        {
            //Act
            var result = value.IsCPF();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("862.432.330-30")]
        [TestCase("86243233030")]
        [TestCase("578.976.730-66")]
        [TestCase("57897673066")]
        [TestCase("123.442.789-12")]
        [TestCase("12344278912")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsCPF_False_Success(string value)
        {
            //Act
            var result = value.IsCPF();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("96.603.172/0001-29")]
        [TestCase("96603172000129")]
        [TestCase("34.595.383/0001-00")]
        [TestCase("34595383000100")]
        [TestCase("94.679.712/0001-22")]
        [TestCase("94679712000122")]
        public void IsCNPJ_True_Success(string value)
        {
            //Act
            var result = value.IsCNPJ();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("95.603.152/0501-25")]
        [TestCase("95603152050125")]
        [TestCase("34.775.773/0077-00")]
        [TestCase("34775773007700")]
        [TestCase("11.679.789/8888-22")]
        [TestCase("11679789888822")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsCNPJ_False_Success(string value)
        {
            //Act
            var result = value.IsCNPJ();

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

        [Test]
        public void IsNull_True_Success()
        {
            //Arrange
            string value1 = null;
            int? value2 = null;

            //Act
            var result1 = value1.IsNull();
            var result2 = value2.IsNull();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.True);
                Assert.That(result2, Is.True);
            });
        }

        [Test]
        public void IsNull_False_Success()
        {
            //Arrange
            var value1 = false;
            var value2 = 1;
            var value3 = "tests";
            var value4 = new { reason = "tests" };

            //Act
            var result1 = value1.IsNull();
            var result2 = value2.IsNull();
            var result3 = value3.IsNull();
            var result4 = value4.IsNull();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.False);
                Assert.That(result2, Is.False);
                Assert.That(result3, Is.False);
                Assert.That(result4, Is.False);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void IsNullOrEmpty_True_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase(" ")]
        public void IsNullOrEmpty_False_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void IsNullOrEmptyOrWhiteSpace_True_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmptyOrWhiteSpace();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Text cannot be null or empty")]
        [TestCase("tests")]
        public void IsNullOrEmptyOrWhiteSpace_False_Success(string value)
        {
            //Act
            var result = value.IsNullOrEmptyOrWhiteSpace();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase("http://wwww.google.com.br")]
        [TestCase("https://wwww.google.com.br")]
        public void IsUrl_True_Success(string value)
        {
            //Act
            var result = value.IsUrl();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Test if it's a url")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsUrl_False_Success(string value)
        {
            //Act
            var result = value.IsUrl();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
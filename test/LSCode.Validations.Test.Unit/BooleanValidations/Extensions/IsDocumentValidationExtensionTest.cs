﻿using LSCode.Validations.BooleanValidations.Extensions;
using NUnit.Framework;

namespace LSCode.Validations.Test.Unit.BooleanValidations.Extensions
{
    [TestFixture]
    internal class IsDocumentValidationExtensionTest
    {
        [Test]
        [TestCase("YE162743")]
        [TestCase("RQ515628")]
        [TestCase("VL171748")]
        [TestCase("ZD256556")]
        public void IsBrazilianPassport_ShouldReturnTrue(string value)
        {
            //Act
            var result = value.IsBrazilianPassport();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("YEV162743")]
        [TestCase("RQ51V5628")]
        [TestCase("22VL1717")]
        [TestCase("ZD2522656")]
        [TestCase("ZD252265N")]
        [TestCase("0ZD252265")]
        [TestCase("!ZD252265")]
        [TestCase("?ZD252265")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsBrazilianPassport_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsBrazilianPassport();

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
        public void IsCPF_ShouldReturnTrue(string value)
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
        public void IsCPF_ShouldReturnFalse(string value)
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
        public void IsCNPJ_ShouldReturnTrue(string value)
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
        public void IsCNPJ_ShouldReturnFalse(string value)
        {
            //Act
            var result = value.IsCNPJ();

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
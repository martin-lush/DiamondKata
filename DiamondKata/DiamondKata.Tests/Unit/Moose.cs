using DiamondKata.Tests.Extensions;
using NUnit.Framework;
using System;
using System.Linq;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class Moose
    {
        [Test]
        public void A_Should_Give_A()
        {
            Assert.AreEqual("A", Diamond.PrintDiamond('A'));
        }

        [Test]
        public void B_Should_Give_Character_Sequence()
        {
            var result = Diamond.PrintDiamond('B').RemoveWhitespaceAndNewLines();
            var distincChars = new string(result.Distinct().ToArray());

            Assert.AreEqual("AB", distincChars);
        }

        [Test]
        public void B_Should_Repeat_Characters()
        {
            var result = Diamond.PrintDiamond('B').RemoveWhitespaceAndNewLines();
            Assert.AreEqual("ABBA", result);
        }

        [Test]
        public void B_Should_Have_Separate_Lines()
        {
            var result = Diamond.PrintDiamond('B').RemoveWhitespace();
            Assert.AreEqual($"A{Environment.NewLine}BB{Environment.NewLine}A", result);
        }

        [Test]
        public void B_Should_Have_Spaces()
        {
            var result = Diamond.PrintDiamond('B').RemoveNewLines();
            Assert.AreEqual($" A B B A ", result);
        }
    }
}

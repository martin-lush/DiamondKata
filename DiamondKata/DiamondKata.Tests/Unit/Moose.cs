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
            Assert.AreEqual("A", new Diamond().PrintDiamond('A'));
        }

        [Test]
        public void B_Should_Give_Character_Sequence()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespaceAndNewLines();
            var distincChars = new string(result?.Distinct().ToArray());

            Assert.AreEqual("AB", distincChars);
        }

        [Test]
        public void B_Should_Repeat_Characters()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespaceAndNewLines();
            Assert.AreEqual("ABBA", result);
        }

        [Test]
        public void B_Should_Have_Separate_Lines()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespace();
            Assert.AreEqual($"A{Environment.NewLine}BB{Environment.NewLine}A", result);
        }

        [Test]
        public void B_Should_Have_Spaces()
        {
            var result = new Diamond().PrintDiamond('B').RemoveNewLines();
            Assert.AreEqual($" A B B A ", result);
        }


        [Test]
        public void B_Should_B_Bigger_Than_A()
        {
            var sut = new Diamond();
            var a = sut.PrintDiamond('A');
            var b = sut.PrintDiamond('B');

            Assert.Greater(b.Length, a.Length);
        }

        [Test]
        public void C_should_be_Bigger_Than_B()
        {
            var sut = new Diamond();
            var b = sut.PrintDiamond('B');
            var c = sut.PrintDiamond('C');

            Assert.Greater(c.Length, b.Length);
        }

        [Test]
        public void D_should_be_Bigger_Than_C()
        {
            var sut = new Diamond();
            var c = sut.PrintDiamond('C');
            var d = sut.PrintDiamond('D');

            Assert.Greater(d.Length, c.Length);
        }
    }
}

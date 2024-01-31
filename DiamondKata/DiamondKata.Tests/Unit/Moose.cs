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
            Assert.That(new Diamond().PrintDiamond('A'), Is.EqualTo("A"));
        }

        [Test]
        public void B_Should_Give_Character_Sequence()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespaceAndNewLines();
            var distincChars = new string(result?.Distinct().ToArray());

            Assert.That(distincChars, Is.EqualTo("AB"));
        }

        [Test]
        public void B_Should_Repeat_Characters()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespaceAndNewLines();
            Assert.That(result, Is.EqualTo("ABBA"));
        }

        [Test]
        public void B_Should_Have_Separate_Lines()
        {
            var result = new Diamond().PrintDiamond('B').RemoveWhitespace();
            Assert.That(result, Is.EqualTo($"A{Environment.NewLine}BB{Environment.NewLine}A"));
        }

        [Test]
        public void B_Should_Have_Spaces()
        {
            var result = new Diamond().PrintDiamond('B').RemoveNewLines();
            Assert.That(result, Is.EqualTo($" A B B A "));
        }


        [Test]
        public void B_Should_B_Bigger_Than_A()
        {
            var sut = new Diamond();
            var a = sut.PrintDiamond('A');
            var b = sut.PrintDiamond('B');

            Assert.That(b.Length, Is.GreaterThan(a.Length));
        }

        [Test]
        public void C_should_be_Bigger_Than_B()
        {
            var sut = new Diamond();
            var b = sut.PrintDiamond('B');
            var c = sut.PrintDiamond('C');

            Assert.That(c.Length, Is.GreaterThan(b.Length));
        }

        [Test]
        public void D_should_be_Bigger_Than_C()
        {
            var sut = new Diamond();
            var c = sut.PrintDiamond('C');
            var d = sut.PrintDiamond('D');

            Assert.That(d.Length, Is.GreaterThan(c.Length));
        }
    }
}

using NUnit.Framework;
using System;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class NegativeTesting
    {
        [Test]
        public void Constructor_Should_Not_Allow_Empty_Alphabet()
        {
            Assert.Throws<ArgumentException>(() => new Diamond(Array.Empty<char>()));
        }

        [Test]
        public void PrintDiamond_Character_Must_Be_Within_Alphabet()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Diamond().PrintDiamond(default));
        }
    }
}

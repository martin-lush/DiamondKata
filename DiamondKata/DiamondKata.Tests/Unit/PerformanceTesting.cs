using NUnit.Framework;
using System.Linq;
using System.Threading;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class PerformanceTesting
    {
        [Test]
        public void Can_Generate_Large_Diamond_Successfully()
        {
            var alphabet = Settings.Alphabet.UpperEnglishAlphabet;
            var result = new Diamond(alphabet).PrintDiamond(alphabet.Last());
            Assert.That(result, Is.Not.Null);
        }

        [Test, CancelAfter(100)]
        public void Large_Diamond_Does_Not_Take_Longer_Than_100_Milliseconds(CancellationToken token)
        {
            var alphabet = Settings.Alphabet.UpperEnglishAlphabet;
            new Diamond(alphabet).PrintDiamond(alphabet.Last());

            Assert.That(token.IsCancellationRequested, Is.False);
        }

        [TestCase(100)]
        [TestCase(10000)]
        [TestCase(1000000)]
        public void Stress_Test(int executionCount)
        {
            var alphabet = Settings.Alphabet.UpperEnglishAlphabet;
            var sut = new Diamond(alphabet);
            for (int i = 0; i < executionCount; i++)
            {
                sut.PrintDiamond(alphabet.Last());
            }
        }
    }
}

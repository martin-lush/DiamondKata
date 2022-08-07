using DiamondKata.Tests.Extensions;
using NUnit.Framework;
using System.Linq;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class GetFirstOrLastLine
    {
        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        public void Should_Not_Repeat_FirstCharacter(char character)
        {
            var sut = new Diamond();

            var result = sut.GetFirstOrLastLine(character).RemoveWhitespace();
            Assert.AreEqual($"{sut.Alphabet[0]}", result);
        }

        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        public void Should_Only_Have_FirstCharacter_And_Whitespace(char character)
        {
            var sut = new Diamond();

            var result = sut.GetFirstOrLastLine(character);

            Assert.IsTrue(result?.All(c => c == sut.Alphabet[0] || char.IsWhiteSpace(c)));
        }

        [TestCase('B', 1)]
        [TestCase('C', 2)]
        [TestCase('D', 3)]
        [TestCase('E', 4)]
        [TestCase('F', 5)]
        public void Should_HaveExpected_Whitespaces_Before(char character, int expectedCount)
        {
            var sut = new Diamond();

            var result = sut.GetFirstOrLastLine(character);

            int start = 0;
            int end = result.IndexOf(sut.Alphabet[0]);
            var startSubString = result.Substring(start, end);

            var whitespaceCount = startSubString.Where(c => char.IsWhiteSpace(c)).Count();

            Assert.AreEqual(expectedCount, whitespaceCount);
        }

        [TestCase('B', 1)]
        [TestCase('C', 2)]
        [TestCase('D', 3)]
        [TestCase('E', 4)]
        [TestCase('F', 5)]
        public void Should_HaveExpected_Whitespaces_After(char character, int expectedCount)
        {
            var sut = new Diamond();

            var result = sut.GetFirstOrLastLine(character);

            int start = result.IndexOf(sut.Alphabet[0]);
            int end = result.Length - result.IndexOf(sut.Alphabet[0]);
            var endSubString = result?.Substring(start, end);

            var whitespaceCount = endSubString?.Where(c => char.IsWhiteSpace(c)).Count();

            Assert.AreEqual(expectedCount, whitespaceCount);
        }
    }
}

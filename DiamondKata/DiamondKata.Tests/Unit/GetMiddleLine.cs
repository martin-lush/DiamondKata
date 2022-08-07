using DiamondKata.Tests.Extensions;
using NUnit.Framework;
using System.Linq;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class GetMiddleLine
    {
        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        public void Should_Repeat_Character(char character)
        {
            var result = new Diamond().GetMiddleLine(character).RemoveWhitespace();
            Assert.AreEqual($"{character}{character}", result);
        }

        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        public void Should_Only_Have_Character_And_Whitespace(char character)
        {
            var result = new Diamond().GetMiddleLine(character).RemoveWhitespace();

            Assert.IsTrue(result?.All(c => c == character || char.IsWhiteSpace(c)));
        }

        [TestCase('B', 1)]
        [TestCase('C', 3)]
        [TestCase('D', 5)]
        [TestCase('E', 7)]
        [TestCase('F', 9)]
        public void Should_HaveExpected_Whitespaces(char character, int expectedCount)
        {
            var result = new Diamond().GetMiddleLine(character).RemoveNewLines();

            var whitespaceCount = result?.Where(c => char.IsWhiteSpace(c)).Count();

            Assert.AreEqual(expectedCount, whitespaceCount);
        }
    }
}

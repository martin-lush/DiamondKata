using DiamondKata.Tests.Extensions;
using NUnit.Framework;
using System.Linq;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class GetDiamondTop
    {
        [TestCase('C', new int[] { 1 })]
        [TestCase('D', new int[] { 2, 1 })]
        [TestCase('E', new int[] { 3, 2, 1 })]
        [TestCase('F', new int[] { 4, 3, 2, 1 })]
        public void Should_HaveExpected_Whitespaces_Before(char character, int[] expectedSpaces)
        {
            var sut = new Diamond();

            var result = sut.GetDiamondTop(character);

            for (int i = 0; i < result.Count; i++)
            {
                string line = result[i];
                char lineCharacter = sut.Alphabet[i + 1];

                int start = 0;
                int end = line.IndexOf(lineCharacter);
                var startSubString = line.Substring(start, end);

                var whitespaceCount = startSubString.Where(c => char.IsWhiteSpace(c)).Count();
                Assert.AreEqual(expectedSpaces[i], whitespaceCount);
            }
        }

        [TestCase('C', new int[] { 1 })]
        [TestCase('D', new int[] { 2, 1 })]
        [TestCase('E', new int[] { 3, 2, 1 })]
        [TestCase('F', new int[] { 4, 3, 2, 1 })]
        public void Should_HaveExpected_Whitespaces_After(char character, int[] expectedSpaces)
        {
            var sut = new Diamond();

            var result = sut.GetDiamondTop(character);

            for (int i = 0; i < result.Count; i++)
            {
                string line = result[i];
                char lineCharacter = sut.Alphabet[i + 1];

                int start = line.LastIndexOf(lineCharacter);
                int end = line.Length - line.LastIndexOf(lineCharacter);
                var endSubString = line.Substring(start, end);

                var whitespaceCount = endSubString.Where(c => char.IsWhiteSpace(c)).Count();
                Assert.AreEqual(expectedSpaces[i], whitespaceCount);
            }
        }

        [TestCase('C', new int[] { 1 })]
        [TestCase('D', new int[] { 1, 3 })]
        [TestCase('E', new int[] { 1, 3, 5 })]
        [TestCase('F', new int[] { 1, 3, 5, 7 })]
        public void Should_HaveExpected_Whitespaces_Between(char character, int[] expectedSpaces)
        {
            var sut = new Diamond();

            var result = sut.GetDiamondTop(character);

            for (int i = 0; i < result.Count; i++)
            {
                string line = result[i];
                char lineCharacter = sut.Alphabet[i + 1];

                int firstIndex = line.IndexOf(lineCharacter);
                int lastIndex = line.LastIndexOf(lineCharacter);
                var betweenSubString = line.Substring(firstIndex + 1, (lastIndex - firstIndex) - 1);

                var whitespaceCount = betweenSubString.Where(c => char.IsWhiteSpace(c)).Count();
                Assert.AreEqual(expectedSpaces[i], whitespaceCount);
            }
        }

        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        public void Should_Only_Have_LineCharacter_And_Whitespace(char character)
        {
            var sut = new Diamond();

            var result = sut.GetDiamondTop(character);

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            for (int i = 0; i < result.Count; i++)
            {
                string line = result[i].RemoveWhitespace();
                Assert.IsTrue(line?.All(c => c == sut.Alphabet[i + 1] || char.IsWhiteSpace(c)));
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

    }
}

using NUnit.Framework;
using System.Text;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class Alphabet
    {
        [Test]
        public void UpperEnglishAlphabet_Generates_Expected_Result()
        {
            StringBuilder sb = new();
            sb.AppendLine("  A  ");
            sb.AppendLine(" B B ");
            sb.AppendLine("C   C");
            sb.AppendLine(" B B ");
            sb.Append("  A  ");

            string expectedResult = sb.ToString();

            var result = new Diamond(Settings.Alphabet.UpperEnglishAlphabet).PrintDiamond('C');

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void LowerEnglishAlphabet_Generates_Expected_Result()
        {
            StringBuilder sb = new();
            sb.AppendLine("  a  ");
            sb.AppendLine(" b b ");
            sb.AppendLine("c   c");
            sb.AppendLine(" b b ");
            sb.Append("  a  ");

            string expectedResult = sb.ToString();

            var result = new Diamond(Settings.Alphabet.LowerEnglishAlphabet).PrintDiamond('c');

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void DecimalAlphabet_Generates_Expected_Result()
        {
            StringBuilder sb = new();
            sb.AppendLine("  0  ");
            sb.AppendLine(" 1 1 ");
            sb.AppendLine("2   2");
            sb.AppendLine(" 1 1 ");
            sb.Append("  0  ");

            string expectedResult = sb.ToString();

            var result = new Diamond(Settings.Alphabet.DecimalAlphabet).PrintDiamond('2');

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void HexidecimalAlphabet_Generates_Expected_Result()
        {
            StringBuilder sb = new();
            sb.AppendLine("  0  ");
            sb.AppendLine(" 1 1 ");
            sb.AppendLine("2   2");
            sb.AppendLine(" 1 1 ");
            sb.Append("  0  ");

            string expectedResult = sb.ToString();

            var result = new Diamond(Settings.Alphabet.HexidecimalAlphabet).PrintDiamond('2');

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

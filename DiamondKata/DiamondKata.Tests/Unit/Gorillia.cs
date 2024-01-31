using NUnit.Framework;
using System.Text;

namespace DiamondKata.Tests.Unit
{
    [TestFixture]
    internal class Gorillia
    {
        [Test]
        public void When_A_Returns_A()
        {
            string expectedResult = "A";

            var result = new Diamond().PrintDiamond('A');

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void When_B_Returns_ABA()
        {
            StringBuilder sb = new();
            sb.AppendLine(" A ");
            sb.AppendLine("B B");
            sb.Append(" A ");

            string expectedResult = sb.ToString();

            var result = new Diamond().PrintDiamond('B');

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void When_C_Returns_ABCBA()
        {
            StringBuilder sb = new();
            sb.AppendLine("  A  ");
            sb.AppendLine(" B B ");
            sb.AppendLine("C   C");
            sb.AppendLine(" B B ");
            sb.Append("  A  ");

            string expectedResult = sb.ToString();

            var result = new Diamond().PrintDiamond('C');

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

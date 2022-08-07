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
            StringBuilder sb = new();
            sb.Append("A");

            string expectedResult = sb.ToString();

            var result = Diamond.PrintDiamond('A');

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void When_B_Returns_ABA()
        {
            StringBuilder sb = new();
            sb.AppendLine(" A ");
            sb.AppendLine("B B");
            sb.Append(" A ");

            string expectedResult = sb.ToString();

            var result = Diamond.PrintDiamond('B');

            Assert.AreEqual(expectedResult, result);
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

            var result = Diamond.PrintDiamond('C');

            Assert.AreEqual(expectedResult, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Text;

namespace Rabbit.Foundation.Tests.Text
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void CanGetSubstring()
        {
            const string source = "This is a test string";

            var substring = source.GetSubstring(3, " ");

            Assert.AreEqual("This", substring);
        }

        [TestMethod]
        public void CanGetSubstring2()
        {
            const string source = "This is a test string. And second string";

            var substring = source.GetSubstring(21, new string[] { " ", "." });

            Assert.AreEqual("This is a test string", substring);
        }
    }
}

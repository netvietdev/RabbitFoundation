using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Text;

namespace Rabbit.Foundation.Tests.Text
{
    [TestClass]
    public class XmlExtensionsTest
    {
        [TestMethod]
        public void CanGetUnicodeText()
        {
            var document = new XmlDocument();
            var customers = document.CreateElement("Customers");
            document.AppendChild(customers);

            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><Customers />", document.ToUnicodeText());
        }

        [TestMethod]
        public void CanGetUnicodeTextOfAnElement()
        {
            var document = new XmlDocument();
            var customers = document.CreateElement("Customers");
            document.AppendChild(customers);

            Assert.AreEqual("<Customers />", customers.ToUnicodeText());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using Rabbit.Foundation.Text;

namespace Rabbit.Foundation.Tests
{
    [TestClass]
    public class StreamExtensionsTest
    {
        [TestMethod]
        public void CanReadAllText()
        {
            var document = new XmlDocument();
            var customers = document.CreateElement("Customers");
            document.AppendChild(customers);

            using (var ms = new MemoryStream())
            {
                var writer = XmlWriter.Create(ms);
                document.WriteTo(writer);
                writer.Flush();

                var xml = ms.ReadAllText();

                Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-8\"?><Customers />", xml);
            }
        }
    }
}

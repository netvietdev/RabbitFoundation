using System.IO;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Extensions;

namespace Rabbit.Foundation.Tests.Text
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

                var xml = ms.ReadAllTextUnicode();

                Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-8\"?><Customers />", xml);
            }
        }
    }
}

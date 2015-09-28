﻿using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Text;

namespace Rabbit.Foundation.Tests
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

            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-8\"?><Customers />", document.ToUnicodeText());
        }
    }
}
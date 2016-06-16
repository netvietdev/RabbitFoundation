using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Rabbit.Foundation.Tests
{
    [TestClass]
    public class CollectionExtensionsTests
    {
        [TestMethod]
        public void CanParseLinesToDictionary()
        {
            var lines = new List<string>
            {
                "Line1 = A1", 
                "Line2 = A2"
            };

            var dict = lines.ToDictionary();

            Assert.AreEqual(2, dict.Count);
            Assert.AreEqual(true, dict.ContainsKey("Line1"));
            Assert.AreEqual("A1", dict.First().Value);
            Assert.AreEqual(true, dict.ContainsKey("Line2"));
            Assert.AreEqual("A2", dict.Last().Value);
        }
    }
}
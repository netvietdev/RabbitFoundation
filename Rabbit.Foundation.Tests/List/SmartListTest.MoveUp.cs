using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.List;

namespace Rabbit.Foundation.Tests.List
{
    public partial class SmartListTest
    {
        [TestMethod]
        public void CanAddItemToList()
        {
            // Arrange
            var list = new SmartList<int>();

            // Act
            list.Add(10);

            // Arrange
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotAddItemToListIfItContainsTheItemAlready()
        {
            // Arrange
            var list = new SmartList<int>(new UniqueListValidator<int>()) { 10 };

            // Act
            list.Add(10);
        }
    }
}

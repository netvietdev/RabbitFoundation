using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.List;

namespace Rabbit.Foundation.Tests.List
{
    public partial class SmartListTest
    {
        [TestMethod]
        public void CanRemoveItemFromList()
        {
            // Arrange
            var list = new SmartList<int>() { 10, 20, 10 };

            // Act
            list.Remove(10);

            // Arrange
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(20, list[0]);
            Assert.AreEqual(10, list[1]);
        }
    }
}

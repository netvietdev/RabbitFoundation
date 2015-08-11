using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.List;

namespace Rabbit.Foundation.Tests.List
{
    public partial class SmartListTest
    {
        [TestMethod]
        public void CanClearAllItems()
        {
            // Arrange
            var list = new SmartList<int>() { 10, 20, 10 };

            // Act
            list.Clear();

            // Arrange
            Assert.AreEqual(0, list.Count);
        }
    }
}

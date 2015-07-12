using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.List;

namespace Rabbit.Foundation.Tests.List
{
    public partial class SmartListTest
    {
        [TestMethod]
        public void CanMoveUpItemInTheList()
        {
            // Arrange
            var list = new SmartList<int>() { 10, 20 };

            // Act
            list.MoveUp(20);

            // Arrange
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(20, list[0]);
            Assert.AreEqual(10, list[1]);
        }

        [TestMethod]
        public void CanMoveUpItemInTheListOnTheFirstItem()
        {
            // Arrange
            var list = new SmartList<int>() { 10, 20 };

            // Act
            list.MoveUp(10);

            // Arrange
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(10, list[0]);
            Assert.AreEqual(20, list[1]);
        }
    }
}

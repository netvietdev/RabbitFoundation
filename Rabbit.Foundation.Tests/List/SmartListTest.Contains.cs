using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.List;

namespace Rabbit.Foundation.Tests.List
{
    public partial class SmartListTest
    {
        [TestMethod]
        public void CanCheckContains()
        {
            // Arrange
            var list = new SmartList<int>() { 10, 20, 10 };

            // Act
            var result = list.Contains(10);

            // Arrange
            Assert.AreEqual(true, result);
        }
    }
}

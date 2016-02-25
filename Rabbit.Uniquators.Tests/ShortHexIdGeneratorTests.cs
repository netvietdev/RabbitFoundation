using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rabbit.Uniquators.Tests
{
    [TestClass]
    public class ShortHexIdGeneratorTests
    {
        [TestMethod]
        public void CanGetNewId()
        {
            // Arrange
            var generator = new ShortHexIdGenerator();

            // Act
            var newId = generator.NewId();

            Console.WriteLine(newId);
            Console.WriteLine("Length " + newId.Length);
        }
    }
}

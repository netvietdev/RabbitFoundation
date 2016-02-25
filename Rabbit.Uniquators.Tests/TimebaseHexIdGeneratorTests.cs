using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rabbit.Uniquators.Tests
{
    [TestClass]
    public class TimebaseHexIdGeneratorTests
    {
        [TestMethod]
        public void CanGetNewId()
        {
            // Arrange
            var generator = new TimebaseHexIdGenerator();

            // Act
            var newId = generator.NewId();

            Console.WriteLine(newId);
            Console.WriteLine("Length " + newId.Length);
        }
    }
}

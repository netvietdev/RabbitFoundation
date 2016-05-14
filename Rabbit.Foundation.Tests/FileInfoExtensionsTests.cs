using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Extensions;

namespace Rabbit.Foundation.Tests
{
    [TestClass]
    public class FileInfoExtensionsTests
    {
        [TestMethod]
        public void CanRenameAFile()
        {
            var file = new FileInfo(@"C:\temp\Test.txt");
            file.Rename("Test2.txt");
        }
    }
}
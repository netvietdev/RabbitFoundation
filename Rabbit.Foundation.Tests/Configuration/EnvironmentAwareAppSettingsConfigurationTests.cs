using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Configuration;

namespace Rabbit.Foundation.Tests.Configuration
{
    [TestClass]
    public class EnvironmentAwareAppSettingsConfigurationTests
    {
        [TestMethod]
        public void CanGetConfigurationFromUserTarget()
        {
            var config = new EnvironmentAwareAppSettingsConfiguration();
            var value = config.Get("CategoryDataFilePath");
            Assert.AreNotEqual(string.Empty, value);
        }
    }
}

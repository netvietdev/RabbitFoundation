using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rabbit.Configuration.Tests
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

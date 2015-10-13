using System;
using System.Configuration;

namespace Rabbit.Foundation.Configuration
{
    /// <summary>
    /// Get configuration keys from AppSettings or User environment variable lists
    /// </summary>
    public class EnvironmentAwareAppSettingsConfiguration : IConfiguration
    {
        public string Get(string key)
        {
            var fromConfig = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrWhiteSpace(fromConfig) || String.Equals(fromConfig, "{ENV}", StringComparison.InvariantCultureIgnoreCase))
            {
                return Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);
            }

            return fromConfig;
        }
    }
}
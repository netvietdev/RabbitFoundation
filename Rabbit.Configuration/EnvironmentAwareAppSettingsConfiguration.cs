using System;
using System.Configuration;

namespace Rabbit.Configuration
{
    public class EnvironmentAwareAppSettingsConfiguration : IConfiguration
    {
        public string Get(string key)
        {
            var fromConfig = ConfigurationManager.AppSettings[key];

            if (String.Equals(fromConfig, "{ENV}", StringComparison.InvariantCultureIgnoreCase))
            {
                return Environment.GetEnvironmentVariable(key);
            }

            return fromConfig;
        }
    }
}
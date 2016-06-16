using System.IO;
using System.Reflection;

namespace Rabbit.Foundation.Extensions
{
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Get content from an embeded file
        /// </summary>
        public static string GetResourceFileContent(this Assembly assembly, string @namespace, string filePath)
        {
            var resourceName = @namespace + "." + filePath;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    return string.Empty;
                }

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}

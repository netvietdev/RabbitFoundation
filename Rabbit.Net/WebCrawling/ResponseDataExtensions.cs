using System.IO;

namespace Rabbit.Net.WebCrawling
{
    public static class ResponseDataExtensions
    {
        public static string ReadAsText(this ResponseData data)
        {
            using (var ms = new MemoryStream(data.Content))
            {
                using (var reader = new StreamReader(ms))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
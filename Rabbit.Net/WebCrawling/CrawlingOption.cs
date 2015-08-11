using System.Net.Http;

namespace Rabbit.Net.WebCrawling
{
    public class CrawlingOption
    {
        public CrawlingOption(string uri)
            : this(uri, HttpMethod.Get)
        {
        }

        public CrawlingOption(string uri, HttpMethod method)
        {
            Uri = uri;
            Method = method;
            Retries = 2;
        }

        public HttpMethod Method { get; set; }
        public string Uri { get; set; }
        public string Data { get; set; }
        public int Retries { get; set; }
    }
}

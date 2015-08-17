using System.Net;

namespace Rabbit.Net.WebCrawling
{
    public interface ISetRequestHeadersStrategy
    {
        void SetRequestHeaders(HttpWebRequest request);
    }
}
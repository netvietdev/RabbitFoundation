using System.Net;

namespace Rabbit.Net.WebCrawling
{
    public sealed class SetChromeRequestHeadersStrategy : ISetRequestHeadersStrategy
    {
        public void SetRequestHeaders(HttpWebRequest request)
        {
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.130 Safari/537.36";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.Headers.Add(HttpRequestHeader.CacheControl, "max-age=0");
        }
    }
}
using System.Net;

namespace Rabbit.Net.WebCrawling
{
    public class ResponseData
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public byte[] Content { get; set; }
    }
}
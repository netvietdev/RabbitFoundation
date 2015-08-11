using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Rabbit.Web.Diagnostics
{
    public static class HttpRequestExtensions
    {
        public static string GetRequestInfo(this HttpRequest request)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("RawUrl: {0}. HttpMethod: {1}", request.RawUrl, request.HttpMethod);

            if (!request.HttpMethod.Equals(HttpMethod.Get.ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                request.InputStream.Position = 0;
                var input = new StreamReader(request.InputStream).ReadToEnd();

                sb.AppendLine();
                sb.AppendFormat("InputStream: {0}", input);
            }

            return sb.ToString();
        }
    }
}

using System;
using System.IO.Compression;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    public class CompressionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            var response = filterContext.HttpContext.Response;

            string acceptEncoding = request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(acceptEncoding))
            {
                return;
            }

            if (acceptEncoding.IndexOf("GZIP", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                response.AppendHeader("Content-Encoding", "gzip");
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
            }
            else if (acceptEncoding.IndexOf("DEFLATE", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                response.AppendHeader("Content-Encoding", "deflate");
                response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
            }
        }
    }
}

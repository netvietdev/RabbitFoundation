using System.Web;

namespace Rabbit.Web.Extensions
{
    public static class HttpContextExtensions
    {
        /// <summary>
        /// Try to get a parameter from QueryString, or in request's Params, or in request's RouteData
        /// </summary>
        public static object GetParamemter(this HttpContextBase httpContext, string parameterName)
        {
            var value = httpContext.Request.QueryString[parameterName];
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            value = httpContext.Request.Params[parameterName];
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            return httpContext.Request.RequestContext.RouteData.Values[parameterName];
        }
    }
}

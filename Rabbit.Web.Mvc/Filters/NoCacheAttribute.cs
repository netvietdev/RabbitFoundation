using System.Web;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    public class NoCacheAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            UpdateCachePolicy(filterContext.HttpContext.Response.Cache);
            base.OnResultExecuting(filterContext);
        }

        private void UpdateCachePolicy(HttpCachePolicyBase cachePolicy)
        {
            cachePolicy.SetNoStore();
            cachePolicy.SetValidUntilExpires(false);
            cachePolicy.SetRevalidation(HttpCacheRevalidation.AllCaches);
            cachePolicy.SetCacheability(HttpCacheability.NoCache);
        }
    }
}

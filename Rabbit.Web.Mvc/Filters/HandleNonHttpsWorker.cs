using System;
using System.Linq;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    /// <summary>
    /// Handle non https
    /// </summary>
    public class HandleNonHttpsWorker
    {
        private readonly string[] _excludeHosts;

        /// <summary>
        /// Init new worker with all exclude hosts
        /// </summary>
        public HandleNonHttpsWorker(params string[] excludeHosts)
        {
            _excludeHosts = excludeHosts;
        }

        /// <summary>
        /// This property is False by default
        /// </summary>
        public bool RequireHttpsLocally
        {
            get;
            set;
        }

        /// <summary>
        /// Validate if the current request is OK to be continuing or not
        /// </summary>
        /// <param name="filterContext"></param>
        /// <returns></returns>
        public virtual bool CanValidate(AuthorizationContext filterContext)
        {
            if (!RequireHttpsLocally && filterContext.HttpContext.Request.IsLocal)
            {
                return true;
            }

            var url = filterContext.HttpContext.Request.Url;
            if (url != null && _excludeHosts.Contains(url.Host, StringComparer.InvariantCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}
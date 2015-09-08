using System;
using System.Linq;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    public class RequireHttpsInProductionAttribute : RequireHttpsAttribute
    {
        private readonly string[] _excludeHosts;

        public RequireHttpsInProductionAttribute(params string[] excludeHosts)
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

        protected override void HandleNonHttpsRequest(AuthorizationContext filterContext)
        {
            if (!RequireHttpsLocally && filterContext.HttpContext.Request.IsLocal)
            {
                return;
            }

            var url = filterContext.HttpContext.Request.Url;
            if (url != null && _excludeHosts.Contains(url.Host, StringComparer.InvariantCultureIgnoreCase))
            {
                return;
            }

            base.HandleNonHttpsRequest(filterContext);
        }
    }
}
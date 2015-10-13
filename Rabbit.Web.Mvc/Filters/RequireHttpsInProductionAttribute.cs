using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    /// <summary>
    /// A custom RequireHttps handler
    /// </summary>
    public class RequireHttpsInProductionAttribute : RequireHttpsAttribute
    {
        private readonly HandleNonHttpsWorker _worker;

        /// <summary>
        /// Instantiate new instance with a worker
        /// </summary>
        /// <param name="worker"></param>
        public RequireHttpsInProductionAttribute(HandleNonHttpsWorker worker)
        {
            _worker = worker;
        }

        protected override void HandleNonHttpsRequest(AuthorizationContext filterContext)
        {
            if (_worker.CanValidate(filterContext))
            {
                return;
            }

            base.HandleNonHttpsRequest(filterContext);
        }
    }
}
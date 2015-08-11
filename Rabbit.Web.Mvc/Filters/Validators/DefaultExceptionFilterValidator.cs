using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters.Validators
{
    public class DefaultExceptionFilterValidator : IExceptionFilterValidator 
    {
        public bool CanProcess(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return false;
            }

            if (filterContext.Exception == null)
            {
                return false;
            }

            return true;
        }
    }
}

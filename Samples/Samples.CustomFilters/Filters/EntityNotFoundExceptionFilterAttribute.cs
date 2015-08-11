using Rabbit.Web.Mvc.Filters;
using Samples.CustomFilters.Models.Exceptions;
using System.Web.Mvc;

namespace Samples.CustomFilters.Filters
{
    public class EntityNotFoundExceptionFilterAttribute : ExceptionFilterAttributeBase
    {
        protected override bool HandleException(ExceptionContext filterContext)
        {
            var ex = GetException<EntityNotFoundException>(filterContext);
            if (ex == null)
            {
                return false;
            }

            filterContext.Result = new ContentResult()
            {
                Content = GetType().FullName,
            };

            return true;
        }
    }
}
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters.Validators
{
    public interface IExceptionFilterValidator
    {
        bool CanProcess(ExceptionContext filterContext);
    }
}

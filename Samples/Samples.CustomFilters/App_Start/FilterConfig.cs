using Samples.CustomFilters.Filters;
using System.Web.Mvc;

namespace Samples.CustomFilters.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // Change order and refresh the page, check what is type name displaying
            filters.Add(new EntityNotFoundExceptionFilterAttribute() { Order = 1 });
            filters.Add(new InvalidParametersExceptionFilterAttribute() { Order = 2 });
        }
    }
}
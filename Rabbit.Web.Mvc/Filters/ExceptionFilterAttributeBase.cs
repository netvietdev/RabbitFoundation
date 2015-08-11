using Rabbit.Web.Mvc.Filters.Validators;
using System;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    public abstract class ExceptionFilterAttributeBase : FilterAttribute, IExceptionFilter
    {
        private readonly IExceptionFilterValidator _filterValidator;

        protected ExceptionFilterAttributeBase()
            : this(new DefaultExceptionFilterValidator())
        {
        }

        protected ExceptionFilterAttributeBase(IExceptionFilterValidator filterValidator)
        {
            _filterValidator = filterValidator;
        }

        public void OnException(ExceptionContext filterContext)
        {
            if (_filterValidator.CanProcess(filterContext) == false)
            {
                return;
            }

            if (HandleException(filterContext))
            {
                filterContext.ExceptionHandled = true;
            }
        }

        protected abstract bool HandleException(ExceptionContext filterContext);

        protected TException GetException<TException>(ExceptionContext filterContext) where TException : Exception
        {
            return filterContext.Exception.GetBaseException() as TException;
        }
    }
}

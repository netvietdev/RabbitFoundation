using System.Transactions;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    /// <summary>
    /// Start a transaction scope when "Action" is starting and Complete when "Action" is executed.
    /// </summary>
    public class AutoTransactionalFilterAttribute : ActionFilterAttribute
    {
        private TransactionScope _scope;

        /// <summary>
        /// By default a transaction will be required. If set to true, this will create a new root transaction.
        /// </summary>
        public bool RequiresNew { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _scope = CreateTransactionScope();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            using (_scope)
            {
                // Only Complete (commit) when having no error on the action
                if (filterContext.Exception == null)
                {
                    _scope.Complete();
                }
            }
        }

        private TransactionScope CreateTransactionScope()
        {
            var scopeOption = RequiresNew ? TransactionScopeOption.RequiresNew : TransactionScopeOption.Required;

            return new TransactionScope(scopeOption, new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
            });
        }
    }
}
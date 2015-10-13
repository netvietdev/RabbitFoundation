using System.Web.Mvc;

namespace Rabbit.Web.Mvc
{
    /// <summary>
    /// Default behavior for MVC application
    /// </summary>
    public class DefaultMvcHttpApplicationBehavior : IHttpApplicationBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        public void OnStart()
        {
            OnBeforeStart();

            AreaRegistration.RegisterAllAreas();

            OnAfterStart();
        }

        /// <summary>
        /// Custom behavior before starting
        /// </summary>
        protected virtual void OnBeforeStart()
        {
        }

        /// <summary>
        /// Custom behavior after started
        /// </summary>
        protected virtual void OnAfterStart()
        {
        }
    }
}
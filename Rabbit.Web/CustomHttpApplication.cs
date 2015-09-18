using System.Web;

namespace Rabbit.Web
{
    /// <summary>
    /// Custom HttpApplication with extended behavior
    /// </summary>
    public abstract class CustomHttpApplication : HttpApplication
    {
        private readonly IHttpApplicationBehavior _applicationBehavior;

        protected CustomHttpApplication(IHttpApplicationBehavior applicationBehavior)
        {
            _applicationBehavior = applicationBehavior;
        }

        protected void Application_Start()
        {
            _applicationBehavior.OnStart();
        }
    }
}

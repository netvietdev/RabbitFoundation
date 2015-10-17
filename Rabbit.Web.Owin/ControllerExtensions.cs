using System;
using System.Web.Http;

namespace Rabbit.Web.Owin
{
    public static class ControllerExtensions
    {
        public static string GetControllerName(this ApiController controller)
        {
            return GetControllerName(controller.GetType().Name);
        }

        public static string GetControllerName(this Type apiControllerType)
        {
            if (typeof(ApiController).IsAssignableFrom(apiControllerType))
            {
                return GetControllerName(apiControllerType.Name);
            }
            return string.Empty;
        }

        private static string GetControllerName(string typeName)
        {
            return typeName.Substring(0, typeName.IndexOf("Controller", StringComparison.InvariantCulture));
        }
    }
}
using Microsoft.Security.Application;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Security
{
    /// <summary>
    /// The binder with ability to handle SafeHtmlAttribute
    /// </summary>
    public class SafeHtmlModelBinder : DefaultModelBinder
    {
        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext,
            PropertyDescriptor propertyDescriptor, object value)
        {
            if (propertyDescriptor.PropertyType == typeof(string) && propertyDescriptor.Attributes.OfType<AllowHtmlAttribute>().Any())
            {
                value = TryGetSafeValue(value);
            }

            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        }

        private static object TryGetSafeValue(object value)
        {
            var valueAsString = value as string;

            if (!string.IsNullOrWhiteSpace(valueAsString))
            {
                value = Sanitizer.GetSafeHtmlFragment(valueAsString);
            }

            return value;
        }
    }
}
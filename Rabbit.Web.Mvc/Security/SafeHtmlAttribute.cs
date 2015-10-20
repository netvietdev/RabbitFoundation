using System;

namespace Rabbit.Web.Mvc.Security
{
    /// <summary>
    /// Apply on property which needs to be treated for safe string
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class SafeHtmlAttribute : Attribute
    {
    }
}

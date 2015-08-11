using System;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions
{
    internal static class UriExtensions
    {
        public static SpecialSite ParseUri(this string uri)
        {
            var domainSlash = uri.IndexOf("/", uri.IndexOf(".", StringComparison.Ordinal), StringComparison.Ordinal);
            var domainPart = uri.Substring(0, domainSlash);

            if (domainPart.EndsWith("wikipedia.org"))
            {
                return SpecialSite.Wikipedia;
            }

            return SpecialSite.Default;
        }
    }
}

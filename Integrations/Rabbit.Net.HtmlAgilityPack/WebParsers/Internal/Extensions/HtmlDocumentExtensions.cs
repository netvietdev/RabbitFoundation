using System.Linq;
using HtmlAgilityPack;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions
{
    public static class HtmlDocumentExtensions
    {
        public static string GetText(this HtmlDocument document, string xpath)
        {
            var nodes = document.DocumentNode.SelectNodes(xpath);
            if (nodes == null)
            {
                return string.Empty;
            }

            var node = nodes.FirstOrDefault();
            return (node == null) ? string.Empty : node.InnerText;
        }
    }
}

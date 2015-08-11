using HtmlAgilityPack;
using Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public class DescriptionParser : IDescriptionParser
    {
        public string GetDescription(HtmlDocument document)
        {
            return document.GetText("/html/head/meta[@name='Description']");
        }
    }
}

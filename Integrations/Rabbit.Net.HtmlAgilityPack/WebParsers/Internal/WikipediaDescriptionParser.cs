using HtmlAgilityPack;
using Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    internal class WikipediaDescriptionParser : IDescriptionParser
    {
        public string GetDescription(HtmlDocument document)
        {
            return document.GetText("/html/body//*/div[@id='bodyContent']/div[@id='mw-content-text']/p");
        }
    }
}

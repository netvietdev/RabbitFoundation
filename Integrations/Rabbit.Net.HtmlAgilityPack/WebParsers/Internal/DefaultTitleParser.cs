using HtmlAgilityPack;
using Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public class DefaultTitleParser : ITitleParser
    {
        public string GetTitle(HtmlDocument document)
        {
            return document.GetText("/html/head/title");
        }
    }
}

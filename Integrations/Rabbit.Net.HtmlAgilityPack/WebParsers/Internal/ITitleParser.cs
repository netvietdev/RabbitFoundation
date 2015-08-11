using HtmlAgilityPack;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public interface ITitleParser
    {
        string GetTitle(HtmlDocument document);
    }
}

using HtmlAgilityPack;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public interface IDescriptionParser
    {
        string GetDescription(HtmlDocument document);
    }
}

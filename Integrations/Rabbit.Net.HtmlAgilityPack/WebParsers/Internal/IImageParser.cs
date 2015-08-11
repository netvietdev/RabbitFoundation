using HtmlAgilityPack;
using Rabbit.Net.WebPageParser;
using System.Collections.Generic;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public interface IImageParser
    {
        IList<ImageInfo> GetImages(HtmlDocument document);
    }
}

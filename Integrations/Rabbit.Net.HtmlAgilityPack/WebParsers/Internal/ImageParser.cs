using HtmlAgilityPack;
using Rabbit.Net.WebPageParser;
using System.Collections.Generic;
using System.Linq;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public class ImageParser : IImageParser
    {
        public IList<ImageInfo> GetImages(HtmlDocument document)
        {
            var imgNodes = document.DocumentNode.SelectNodes("//img");

            return (from node in imgNodes
                    let alt = node.GetAttributeValue("alt", string.Empty)
                    let src = node.GetAttributeValue("src", string.Empty)
                    let width = node.GetAttributeValue("width", 0)
                    let height = node.GetAttributeValue("height", 0)
                    select new ImageInfo()
                    {
                        Title = alt,
                        Url = src
                    })
                .ToList();
        }
    }
}

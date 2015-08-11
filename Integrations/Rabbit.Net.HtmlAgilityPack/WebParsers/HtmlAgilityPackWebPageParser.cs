using HtmlAgilityPack;
using Rabbit.Net.HtmlAgilityPack.WebParsers.Internal;
using Rabbit.Net.WebPageParser;
using System.Net;
using System.Text;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers
{
    public class HtmlAgilityPackWebPageParser : IWebPageParser
    {
        public WebPageInfo Parse(string uri)
        {
            var request = WebRequest.Create(uri);
            var responseStream = request.GetResponse().GetResponseStream();

            var htmlDocument = new HtmlDocument();
            htmlDocument.Load(responseStream, Encoding.UTF8);

            var parserFactory = new ParserFactory();

            return new WebPageInfo()
            {
                Title = parserFactory.CreateTitleParser(uri).GetTitle(htmlDocument),
                Description = parserFactory.CreateDescriptionParser(uri).GetDescription(htmlDocument),
                Images = parserFactory.CreateImageParser().GetImages(htmlDocument)
            };
        }
    }
}

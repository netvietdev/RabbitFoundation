using Rabbit.Net.HtmlAgilityPack.WebParsers.Internal.Extensions;

namespace Rabbit.Net.HtmlAgilityPack.WebParsers.Internal
{
    public class ParserFactory
    {
        public ITitleParser CreateTitleParser(string uri)
        {
            switch (uri.ParseUri())
            {
                default:
                    return new DefaultTitleParser();
            }
        }

        public IDescriptionParser CreateDescriptionParser(string uri)
        {
            switch (uri.ParseUri())
            {
                case SpecialSite.Wikipedia:
                    return new WikipediaDescriptionParser();
                default:
                    return new DescriptionParser();
            }
        }

        public IImageParser CreateImageParser()
        {
            return new ImageParser();
        }
    }
}

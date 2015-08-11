using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Net.HtmlAgilityPack.WebParsers;
using Rabbit.Net.WebPageParser;

namespace Rabbit.Net.HtmlAgilityPack.Tests
{
    [TestClass]
    public class WebPageParserTest
    {
        [TestMethod]
        public void CanParseHtmlPageGithub()
        {
            const string address = "https://github.com/";
            var sut = CreateSUT();

            var result = sut.Parse(address);
        }

        [TestMethod]
        public void CanParseHtmlPageWikipedia()
        {
            const string address = "https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)";
            var sut = CreateSUT();

            var result = sut.Parse(address);
        }

        private IWebPageParser CreateSUT()
        {
            return new HtmlAgilityPackWebPageParser();
        }
    }
}

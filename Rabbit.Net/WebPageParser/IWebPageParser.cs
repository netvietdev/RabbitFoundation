namespace Rabbit.Net.WebPageParser
{
    public interface IWebPageParser
    {
        WebPageInfo Parse(string uri);
    }
}

namespace Rabbit.Net.WebCrawling
{
    public interface IWebRequestWorker
    {
        ResponseData DownloadResponse(CrawlingOption option);
    }
}
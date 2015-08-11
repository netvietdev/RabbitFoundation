using System.Collections.Generic;

namespace Rabbit.Net.WebPageParser
{
    public class WebPageInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public IList<ImageInfo> Images { get; set; }
    }
}

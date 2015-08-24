﻿using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Rabbit.Net.WebCrawling
{
    public class ResponseData
    {
        public ResponseData()
        {
            Headers = new Dictionary<string, string>();
        }

        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public IDictionary<string, string> Headers { get; set; }

        public Stream ResponseStream { get; set; }

        public byte[] Content
        {
            get
            {
                if (ResponseStream == null)
                {
                    return null;
                }

                using (var ms = new MemoryStream())
                {
                    ResponseStream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
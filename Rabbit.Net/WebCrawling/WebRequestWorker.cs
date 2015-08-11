﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Rabbit.Net.WebCrawling
{
    public sealed class WebRequestWorker : IWebRequestWorker
    {
        public ResponseData DownloadResponse(CrawlingOption option)
        {
            var request = WebRequest.Create(new Uri(option.Uri));
            request.ContentType = "application/x-www-form-urlencoded";

            if (HttpMethod.Get == option.Method)
            {
                return GetResponseData((HttpWebResponse)request.GetResponse());
            }

            if (HttpMethod.Post == option.Method)
            {
                request.Method = option.Method.ToString().ToUpper();
                return GetPostResponseData(request, option);
            }

            throw new NotSupportedException(string.Format("Not supported the {0} method", option.Method));
        }

        private ResponseData GetPostResponseData(WebRequest request, CrawlingOption option)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(option.Data);
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            using (var dataStream = request.GetRequestStream())
            {
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
            }

            // Get the response.
            var response = request.GetResponse();
            return GetResponseData((HttpWebResponse)response);
        }

        private ResponseData GetResponseData(HttpWebResponse response)
        {
            var result = new ResponseData
            {
                StatusCode = response.StatusCode,
                StatusDescription = response.StatusDescription
            };

            var responseStream = response.GetResponseStream();
            if (responseStream != null)
            {
                result.Content = new StreamReader(responseStream).ReadToEnd();
            }

            return result;
        }
    }
}
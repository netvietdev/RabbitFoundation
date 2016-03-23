using System.IO;
using System.Net;
using System.Xml.Linq;

namespace Rabbit.Net.Imgur
{
    public class ImgurUploader
    {
        /// <summary>
        /// Upload an image to imgur.com.
        /// Just registering an application and call this method with the correct client ID
        /// </summary>
        public XDocument Upload(string clientId, ImageData image)
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("Authorization", "Client-ID " + clientId);
                var values = image.ToNameValueCollection();

                byte[] response = w.UploadValues("https://api.imgur.com/3/upload.xml", values);
                return XDocument.Load(new MemoryStream(response));
            }
        }
    }
}

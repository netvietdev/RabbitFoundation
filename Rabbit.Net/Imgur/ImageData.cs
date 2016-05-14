using System;

namespace Rabbit.Net.Imgur
{
    /// <summary>
    /// For detail, go here http://api.imgur.com/endpoints/image#image-upload
    /// </summary>
    public class ImageData
    {
        public ImageData(byte[] imageBytes)
            : this(Convert.ToBase64String(imageBytes))
        {
        }

        public ImageData(string image)
        {
            if (string.IsNullOrWhiteSpace(image))
            {
                throw new ArgumentException("Invalid image data");
            }

            Image = image;
        }

        /// <summary>
        /// Required. A binary file, base64 data, or a URL for an image. (up to 10MB)
        /// </summary>
        public string Image
        {
            get;
            private set;
        }

        public string Album { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
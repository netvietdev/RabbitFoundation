using System.Collections.Specialized;

namespace Rabbit.Net.Imgur
{
    public static class ImgurUploaderExtensions
    {
        public static NameValueCollection ToNameValueCollection(this ImageData imageData)
        {
            var values = new NameValueCollection
            {
                {"image", imageData.Image}
            };

            if (!string.IsNullOrWhiteSpace(imageData.Album))
            {
                values.Add("album", imageData.Album);
            }
            if (!string.IsNullOrWhiteSpace(imageData.Type))
            {
                values.Add("type", imageData.Type);
            }
            if (!string.IsNullOrWhiteSpace(imageData.Name))
            {
                values.Add("name", imageData.Name);
            }
            if (!string.IsNullOrWhiteSpace(imageData.Title))
            {
                values.Add("title", imageData.Title);
            }
            if (!string.IsNullOrWhiteSpace(imageData.Description))
            {
                values.Add("description", imageData.Description);
            }

            return values;
        }
    }
}
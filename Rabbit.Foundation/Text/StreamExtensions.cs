using System;
using System.IO;
using System.Text;

namespace Rabbit.Foundation.Text
{
    /// <summary>
    /// Extension methods for Stream type
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Read stream and returns its content as unicode text
        /// </summary>
        public static string ReadAllTextUnicode(this Stream stream)
        {
            return ReadAllText(stream, Encoding.Unicode);
        }

        /// <summary>
        /// Read stream and returns its content as text
        /// </summary>
        public static string ReadAllText(this Stream stream, Encoding encoding)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            if (stream.Length == 0)
            {
                return string.Empty;
            }

            using (var reader = new StreamReader(stream, encoding))
            {
                stream.Position = 0;
                return reader.ReadToEnd();
            }
        }
    }
}

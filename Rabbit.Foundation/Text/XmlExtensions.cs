using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Rabbit.Foundation.Text
{
    public static class XmlExtensions
    {
        /// <summary>
        /// Convert document to text in Unicode encoding
        /// </summary>
        public static string ToUnicodeText(this XmlNode xmlNode)
        {
            return ToText(xmlNode, Encoding.Unicode);
        }

        /// <summary>
        /// Convert document to text
        /// </summary>
        public static string ToText(this XmlNode xmlNode, Encoding encoding)
        {
            if (xmlNode == null)
            {
                throw new ArgumentNullException("xmlNode");
            }

            using (var ms = new MemoryStream())
            {
                var writer = XmlWriter.Create(ms);
                xmlNode.WriteTo(writer);
                writer.Flush();

                return ms.ReadAllText(encoding);
            }
        }
    }
}
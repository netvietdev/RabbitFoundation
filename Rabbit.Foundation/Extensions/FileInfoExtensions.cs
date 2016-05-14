using System;
using System.IO;

namespace Rabbit.Foundation.Extensions
{
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Rename a file to the new name
        /// </summary>
        public static void Rename(this FileInfo fileInfo, string newName)
        {
            if (!fileInfo.Exists)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(fileInfo.DirectoryName))
            {
                throw new ArgumentException("Cannot get directory name of the file");
            }

            fileInfo.MoveTo(Path.Combine(fileInfo.DirectoryName, newName));
        }
    }
}
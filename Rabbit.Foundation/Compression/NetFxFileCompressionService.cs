using System.IO;
using System.IO.Compression;

namespace Rabbit.Foundation.Compression
{
    /// <summary>
    /// Use dotnet internal functions for compression
    /// </summary>
    public class NetFxFileCompressionService : IFileCompressionService
    {
        public string Compress(string filePath)
        {
            var archiveFileName = Path.ChangeExtension(filePath, ".zip");

            using (var archive = ZipFile.Open(archiveFileName, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
            }

            return archiveFileName;
        }

        public void Compress(string filePath, string compressionPath)
        {
            using (var archive = ZipFile.Open(compressionPath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
            }
        }
    }
}
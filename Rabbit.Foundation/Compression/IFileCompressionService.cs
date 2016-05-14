namespace Rabbit.Foundation.Compression
{
    public interface IFileCompressionService
    {
        /// <summary>
        /// Compresses a file and returns path of the new file (in the same directory with original file)
        /// </summary>
        string Compress(string filePath);

        /// <summary>
        /// Compresses a file to the given path
        /// </summary>
        void Compress(string filePath, string compressionPath);
    }
}
using System.IO;

namespace Simple.Redis.Extensions
{
    public static class MemoryStreamExtensions
    {
        private static readonly byte[] newline = new byte[] { 13, 10 };

        public static void WriteNewLine(this MemoryStream stream)
        {
            stream.Write(newline, 0, 2);
        }
    }
}

using System;

namespace Amadeus.Utilities
{
    public sealed class FileHandler
    {
        public static FileHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<FileHandler> _instance = new Lazy<FileHandler>(() => new FileHandler());

        private FileHandler()
        {
        }
    }
}

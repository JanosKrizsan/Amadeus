using Amadeus.InterfacesForUtilities;
using System;

namespace Amadeus.Utilities
{
    public sealed class FileHandler : IFileHandler
    {
        public static FileHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<FileHandler> _instance = new Lazy<FileHandler>(() => new FileHandler());

        private FileHandler()
        {
            InitFolders();
        }

        public void InitFolders()
        {
        }

        public void SaveObject(SaveTypes saveType)
        {
        }

        public void SaveUser(SaveTypes saveType)
        {
        }

        public void SaveScript()
        {
        }

        public void SaveReport()
        {
        }

        public object LoadItem(ItemTypes itemType, SaveTypes saveType)
        {
            return new object();
        }
    }
}

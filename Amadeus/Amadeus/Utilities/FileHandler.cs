using Amadeus.InterfacesForUtilities;
using static Amadeus.Utilities.EnumsHelper;
using System;
using System.IO;
using System.Linq;
using Amadeus.InfoStructs;

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
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (!Directory.Exists(string.Concat(parent, EnumToString(ItemTypes.USER))))
            {
                foreach (var type in Enum.GetValues(typeof(ItemTypes)).Cast<ItemTypes>())
                {
                    Directory.CreateDirectory(string.Concat(parent, EnumToString(type)));
                }
            }
        }

        public void SaveObject(SaveTypes saveType, object obj)
        {
        }

        public void SaveUser(SaveTypes saveType, UserInfo user)
        {
        }

        public void SaveScript(string script)
        {
        }

        public void SaveReport(string report)
        {
        }

        public object LoadItem(ItemTypes itemType, SaveTypes saveType)
        {
            return null;
        }
    }
}

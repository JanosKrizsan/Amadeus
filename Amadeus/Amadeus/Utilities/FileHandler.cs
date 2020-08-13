﻿using Amadeus.InterfacesForUtilities;
using static Amadeus.Utilities.EnumsHelper;
using System;
using System.IO;
using System.Linq;

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
            if (!Directory.Exists(string.Concat(parent, EnumToString(ItemTypes.User))))
            {
                foreach (var type in Enum.GetValues(typeof(ItemTypes)).Cast<ItemTypes>())
                {
                    Directory.CreateDirectory(string.Concat(parent, EnumToString(type)));
                }
            }
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
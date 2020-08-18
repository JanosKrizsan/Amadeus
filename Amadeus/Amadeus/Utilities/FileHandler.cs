using Amadeus.InterfacesForUtilities;
using static Amadeus.Utilities.EnumsHelper;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using CsvHelper;
using System.Windows.Forms;

namespace Amadeus.Utilities
{
    public sealed class FileHandler : IFileHandler
    {
        public static FileHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<FileHandler> _instance = new Lazy<FileHandler>(() => new FileHandler());
        private Dictionary<string, string> _directories;
        private HelperFunctions _helper;

        private FileHandler()
        {
            InitFolders();
            _helper = new HelperFunctions();
        }

        public void InitFolders()
        {
            var parentDir = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (!Directory.Exists(string.Concat(parentDir, EnumToString(FolderTypes.USER))))
            {
                foreach (var type in Enum.GetValues(typeof(FolderTypes)).Cast<FolderTypes>())
                {
                    var folderName = EnumToString(type);
                    var dirPath = string.Concat(parentDir, folderName);
                    Directory.CreateDirectory(dirPath);
                    _directories.Add(folderName, dirPath);
                }
            }
        }

        public void SaveObject(FolderTypes itemType, FileTypes saveType, ObjectTypes objType, object obj)
        {
            if (_helper.AreValuesValid(itemType, saveType, objType)
)
            {

            }
        }

        public object LoadObject(FolderTypes itemType, FileTypes saveType, ObjectTypes objType)
        {
            if (_helper.AreValuesValid(itemType, saveType, objType))
            {

            }

            return null;
        }

        internal sealed class HelperFunctions : IHelperFunctions
        {
            internal HelperFunctions()
            { }

            public void SaveToTXT(string fullPath, object data)
            {
                var text = new JavaScriptSerializer().Serialize(data);
                using (StreamWriter output = new StreamWriter(fullPath))
                {
                    output.Write(text);
                }
            }
            public void SaveToXML(string fullPath, object data)
            {

            }

            public void SaveToCSV(string fullPath, object data)
            {
                using (var csv = new CsvWriter(new StreamWriter(fullPath), System.Globalization.CultureInfo.CurrentCulture))
                {
                    csv.Configuration.AutoMap(data.GetType());
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.Delimiter = ",";
                    csv.WriteRecord(data);
                }
            }

            public void SaveToRDP(string fullPath, object data)
            {
                SaveToTXT(fullPath, data);
                ChangeFileExtension(fullPath, EnumToString(FileTypes.RDP));
            }

            public void ChangeFileExtension(string fullPath, string newExt)
            {
                File.Move(fullPath, Path.ChangeExtension(fullPath, newExt));
            }


            public bool AreValuesValid(FolderTypes itemType, FileTypes saveType, ObjectTypes objType)
            {
                string[] vals = { EnumToString(itemType), EnumToString(saveType), EnumToString(objType) };
                return CheckVals(vals);
            }
            private bool CheckVal(string val)
            {
                return !string.IsNullOrEmpty(val);
            }

            private bool CheckVals(string[] vals)
            {
                foreach (var val in vals)
                {
                    if (!CheckVal(val))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}

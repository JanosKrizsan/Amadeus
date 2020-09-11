using Amadeus.InterfacesForUtilities;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using CsvHelper;
using System.Xml.Serialization;
using System.Text;

namespace Amadeus.Utilities
{
    public sealed class FileHandler : IFileHandler
    {
        public static FileHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<FileHandler> _instance = new Lazy<FileHandler>(() => new FileHandler());
        private TypeHolder _holder;
        private Dictionary<string, string> _directories;
        private HelperFunctions _helper;

        private FileHandler()
        {
            InitFolders();
            _helper = new HelperFunctions(_directories);
            _holder = TypeHolder.Instance;
        }

        public void InitFolders()
        {
            _directories = new Dictionary<string, string>();
            var parentDir = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (!Directory.Exists(string.Concat(parentDir, _holder.Files["User"])))
            {
                foreach (var folderType in _holder.Files.Keys)
                {
                    var folderName = _holder.Files[folderType];
                    var dirPath = string.Concat(parentDir, folderName);
                    Directory.CreateDirectory(dirPath);
                    _directories.Add(folderName, dirPath);
                }
            }
        }

        public void SaveObject(string itemType, string saveType, string objType, object obj)
        {
            if (_helper.AreValuesValid(itemType, saveType, objType))
            {
                var fileName = obj.GetType().Name.GetHashCode().ToString().Substring(0, 5);
                _helper.ConstructPath(itemType, objType, fileName, saveType);
            }
        }

        public object LoadObject(string itemType, string saveType, string objType)
        {
            if (_helper.AreValuesValid(itemType, saveType, objType))
            {

            }

            return null;
        }

        internal sealed class HelperFunctions : IHelperFunctions
        {
            private Dictionary<string, string> _dirs;
            private TypeHolder _holder;
            internal HelperFunctions(Dictionary<string, string> dirs)
            {
                _dirs = dirs;
                _holder = TypeHolder.Instance;
            }

            public void SaveToTXT(string fullPath, object data)
            {
                var text = new JavaScriptSerializer().Serialize(data);
                using (var output = new StreamWriter(fullPath))
                {
                    output.Write(text);
                }
            }
            public void SaveToXML(string fullPath, object data)
            {
                var serializer = new XmlSerializer(data.GetType());
                using (var output = new StreamWriter(fullPath))
                {
                    serializer.Serialize(output, data);
                    output.Flush();
                }
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
                ChangeFileExtension(fullPath, _holder.Files["RDP"]);
            }

            public void ChangeFileExtension(string fullPath, string newExt)
            {
                File.Move(fullPath, Path.ChangeExtension(fullPath, newExt));
            }


            public bool AreValuesValid(string itemType, string saveType, string objType)
            {
                string[] vals = { itemType, saveType, objType };
                return CheckVals(vals);
            }

            public string ConstructPath(string targetFolder, string namePreFace, string fileName, string extension)
            {
                var targetDir = GetDirectory(targetFolder);
                if (string.IsNullOrEmpty(targetDir))
                {
                    throw new InvalidDataException();
                }
                var pathBuilder = new StringBuilder();
                pathBuilder.Append(targetDir).Append(namePreFace).Append(fileName).Append(extension);
                return pathBuilder.ToString();
            }

            private string GetDirectory(string targetFolder)
            {
                foreach (var dir in _dirs)
                {
                    if (dir.Key.Equals(targetFolder))
                    {
                        return dir.Value;
                    }
                }
                return string.Empty;
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

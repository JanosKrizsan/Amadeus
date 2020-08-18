using Amadeus.Utilities;

namespace Amadeus.InterfacesForUtilities
{
    /// <summary>
    /// Function names are self-explanatory
    /// </summary>
    interface IHelperFunctions
    {
        void SaveToTXT(string fullPath, object data);
        void SaveToXML(string fullPath, object data);
        void SaveToCSV(string fullPath, object data);
        void SaveToRDP(string fullPath, object data);
        void ChangeFileExtension(string fullPath, string newExt);
        bool AreValuesValid(FolderTypes itemType, FileTypes saveType, ObjectTypes objType);
        string ConstructPath(FolderTypes targetFolder, ObjectTypes namePreFace, string fileName, FileTypes extension);

    }
}

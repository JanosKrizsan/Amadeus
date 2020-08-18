using Amadeus.InfoStructs;
using Amadeus.Utilities;

namespace Amadeus.InterfacesForUtilities
{
    /// <summary>
    /// Most function names are self-explanatory
    /// </summary>
    interface IFileHandler
    {
        /// <summary>
        /// Creates folders if not found
        /// </summary>
        void InitFolders();
        void SaveObject(FolderTypes itemType, FileTypes saveType, ObjectTypes objType, object obj);
        object LoadObject(FolderTypes itemType, FileTypes saveType, ObjectTypes objType);
    }
}

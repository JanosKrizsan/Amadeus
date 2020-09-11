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
        void SaveObject(string itemType, string saveType, string objType, object obj);
        object LoadObject(string itemType, string saveType, string objType);
    }
}

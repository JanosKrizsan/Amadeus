using Amadeus.Utilities;

namespace Amadeus.InterfacesForUtilities
{
    interface IFileHandler
    {
        void InitFolders();
        void SaveObject(SaveTypes saveType);
        void SaveUser(SaveTypes saveType);
        void SaveScript();
        void SaveReport();
        object LoadItem(ItemTypes itemType, SaveTypes saveType);
    }
}

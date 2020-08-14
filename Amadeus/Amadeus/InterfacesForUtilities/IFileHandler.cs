using Amadeus.InfoStructs;
using Amadeus.Utilities;

namespace Amadeus.InterfacesForUtilities
{
    interface IFileHandler
    {
        void InitFolders();
        void SaveObject(SaveTypes saveType, object obj);
        void SaveUser(SaveTypes saveType, UserInfo user);
        void SaveScript(string script);
        void SaveReport(string report);
        object LoadItem(ItemTypes itemType, SaveTypes saveType);
    }
}

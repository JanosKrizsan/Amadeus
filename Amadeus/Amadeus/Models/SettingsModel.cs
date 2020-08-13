using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class SettingsModel : CommonModel, ISettingsMod
    {
        public SettingsModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

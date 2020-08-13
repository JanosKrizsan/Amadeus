using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class MacModel : CommonModel, IMacMod
    {
        public MacModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

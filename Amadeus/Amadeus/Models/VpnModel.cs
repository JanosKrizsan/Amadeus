using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class VpnModel : CommonModel, IVpnMod
    {
        public VpnModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

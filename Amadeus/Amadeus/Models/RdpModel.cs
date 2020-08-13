using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class RdpModel : CommonModel, IRdpMod
    {
        public RdpModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class IPModel : CommonModel, IIpMod
    {

        public IPModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

using Amadeus.InterfacesForModels;

namespace Amadeus.Models
{
    class ProxyModel : CommonModel, IProxyMod
    {
        public ProxyModel(string[] ctrlInfo) : base(ctrlInfo)
        {
        }

        public override void FillFormData(string[] dataKeys)
        {
        }
    }
}

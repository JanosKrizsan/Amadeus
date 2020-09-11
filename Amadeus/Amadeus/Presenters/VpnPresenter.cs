using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class VpnPresenter : CommonPresenter, IVpnPres
    {
        public VpnPresenter(IVpnView view) : base(view)
        {
            _model = new VpnModel(ViewInfo);
        }
    }
}

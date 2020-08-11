using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class IPPresenter : CommonPresenter, IIPPRes
    {
        public IPPresenter(IIpAddressView view, IIpMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

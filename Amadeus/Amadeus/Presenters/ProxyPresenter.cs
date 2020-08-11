using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class ProxyPresenter : CommonPresenter, IProxyPRes
    {
        public ProxyPresenter(IProxyView view, IProxyMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

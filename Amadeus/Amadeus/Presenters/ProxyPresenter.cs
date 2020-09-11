using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class ProxyPresenter : CommonPresenter, IProxyPRes
    {
        public ProxyPresenter(IProxyView view) : base(view)
        {
            _model = new ProxyModel(ViewInfo);
        }
    }
}

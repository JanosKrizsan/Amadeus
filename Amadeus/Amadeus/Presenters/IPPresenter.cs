using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class IPPresenter
    {
        private IIpMod _model;
        private IIPAddressPres _view;

        public IPPresenter(IIpMod model, IIPAddressPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

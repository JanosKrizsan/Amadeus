using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class VpnPresenter
    {
        private IVpnMod _model;
        private IVpnPres _view;

        public VpnPresenter(IVpnMod model, IVpnPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

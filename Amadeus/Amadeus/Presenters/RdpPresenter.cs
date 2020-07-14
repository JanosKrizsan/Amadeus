using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class RdpPresenter
    {
        private IRdpMod _model;
        private IRdpPres _view;

        public RdpPresenter(IRdpMod model, IRdpPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

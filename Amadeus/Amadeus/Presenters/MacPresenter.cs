using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MacPresenter
    {
        private IMacMod _model;
        private IMacAddressPres _view;

        public MacPresenter(IMacMod model, IMacAddressPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

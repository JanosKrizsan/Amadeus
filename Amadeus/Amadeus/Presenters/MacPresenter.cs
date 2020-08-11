using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MacPresenter : CommonPresenter, IMacPres
    {
        public MacPresenter(IMacAddressView view, IMacMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

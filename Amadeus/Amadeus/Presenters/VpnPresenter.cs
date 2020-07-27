using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class VpnPresenter : CommonPresenter, IVpnPres
    {
        public VpnPresenter(ICommonView view, ICommonModel model)
        {
            _view = view;
            _model = model;
        }
    }
}

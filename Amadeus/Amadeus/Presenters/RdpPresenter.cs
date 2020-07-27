using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class RdpPresenter : CommonPresenter, IRdpPres
    {
        public RdpPresenter(ICommonView view, ICommonModel model)
        {
            _view = view;
            _model = model;
        }
    }
}

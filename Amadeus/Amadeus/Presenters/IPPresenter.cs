using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class IPPresenter : CommonPresenter, IIPPRes
    {
        public IPPresenter(ICommonView view, ICommonModel model)
        {
            _view = view;
            _model = model;
        }
    }
}

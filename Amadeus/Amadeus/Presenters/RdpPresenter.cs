using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class RdpPresenter : CommonPresenter, IRdpPres
    {
        public RdpPresenter(IRdpView view) : base(view)
        {
            _model = new RdpModel(ViewInfo);
        }
    }
}

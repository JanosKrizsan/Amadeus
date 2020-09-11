using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class MacPresenter : CommonPresenter, IMacPres
    {
        public MacPresenter(IMacAddressView view) : base(view)
        {
            _model = new MacModel(ViewInfo);
        }
    }
}

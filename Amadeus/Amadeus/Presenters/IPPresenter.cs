using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class IPPresenter : CommonPresenter, IIPPRes
    {
        public IPPresenter(IIpAddressView view) : base(view)
        {
            _model = new IPModel(ViewInfo);
        }
    }
}
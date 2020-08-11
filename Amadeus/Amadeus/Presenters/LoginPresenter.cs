using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class LoginPresenter : CommonPresenter, ILoginPres
    {
        public LoginPresenter(ILoginWinView view, ILoginMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

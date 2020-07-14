using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class LoginPresenter
    {
        private ILoginMod _model;
        private ILoginWinPres _view;

        public LoginPresenter(ILoginMod model, ILoginWinPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

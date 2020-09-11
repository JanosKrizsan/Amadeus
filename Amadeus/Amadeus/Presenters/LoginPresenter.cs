using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class LoginPresenter : CommonPresenter, ILoginPres
    {
        public LoginPresenter(ILoginWinView view) : base(view)
        {
            _model = new LoginModel(ViewInfo);
        }
    }
}

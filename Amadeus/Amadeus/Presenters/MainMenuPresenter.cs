using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class MainMenuPresenter : CommonPresenter, IMainMenuPres
    {
        public MainMenuPresenter(IMainMenuView view) : base(view)
        {
            _model = new MainMenuModel(ViewInfo);
        }
    }
}

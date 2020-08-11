using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MainMenuPresenter : CommonPresenter, IMainMenuPres
    {
        public MainMenuPresenter(IMainMenuView view, IMainMenuMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

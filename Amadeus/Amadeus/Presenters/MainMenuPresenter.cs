using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MainMenuPresenter
    {
        private IMainMenuMod _model;
        private IMainMenuPres _view;

        public MainMenuPresenter(IMainMenuMod model, IMainMenuPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

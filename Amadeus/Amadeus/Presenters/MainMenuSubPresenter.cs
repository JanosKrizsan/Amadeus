using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MainMenuSubPresenter
    {
        private IMainMenuSubMod _model;
        private IMainMenuSubPres _view;
        public MainMenuSubPresenter(IMainMenuSubMod model, IMainMenuSubPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

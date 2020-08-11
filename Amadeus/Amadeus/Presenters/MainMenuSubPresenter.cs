using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class MainMenuSubPresenter : CommonPresenter, IMainMenuSubPres
    {
        public MainMenuSubPresenter(IMainMenuSubView view, IMainMenuSubMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

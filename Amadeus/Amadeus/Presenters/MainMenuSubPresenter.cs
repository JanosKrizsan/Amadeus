using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class MainMenuSubPresenter : CommonPresenter, IMainMenuSubPres
    {
        public MainMenuSubPresenter(IMainMenuSubView view) : base(view)
        {
            _model = new MainMenuSubModel(ViewInfo);
        }
    }
}

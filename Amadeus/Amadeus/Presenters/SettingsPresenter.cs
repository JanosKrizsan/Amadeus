using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class SettingsPresenter : CommonPresenter, ISettingsPres
    {
        public SettingsPresenter(ISettingsView view, ISettingsMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class SettingsPresenter
    {
        private ISettingsMod _model;
        private ISettingsPres _view;

        public SettingsPresenter(ISettingsMod model, ISettingsPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

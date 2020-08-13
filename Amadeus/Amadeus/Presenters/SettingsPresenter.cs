using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class SettingsPresenter : CommonPresenter, ISettingsPres
    {
        public SettingsPresenter(ISettingsView view) : base(view)
        {
            _model = new SettingsModel(ViewInfo);
        }
    }
}

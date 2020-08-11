using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class SysLangPresenter : CommonPresenter, ISysLangPres
    {
        public SysLangPresenter(ISysLanguageView view, ISysLanguageMod model)
        {
            _view = view;
            _model = model;
        }
    }
}

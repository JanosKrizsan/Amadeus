using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class SysLangPresenter
    {
        private ISysLanguageMod _model;
        private ISysLangPres _view;

        public SysLangPresenter(ISysLanguageMod model, ISysLangPres view)
        {
            _model = model;
            _view = view;
        }
    }
}

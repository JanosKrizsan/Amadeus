using Amadeus.InterfacesForPresenters;
using Amadeus.InterfacesForViews;
using Amadeus.Models;

namespace Amadeus.Presenters
{
    class SysLangPresenter : CommonPresenter, ISysLangPres
    {
        public SysLangPresenter(ISysLanguageView view) : base(view)
        {
            _model = new SysLangModel(ViewInfo);
        }
    }
}

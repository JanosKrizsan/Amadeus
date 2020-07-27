using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class SysLangView : CommonView, ISysLanguageView
    {
        public SysLangView(Form form)
        {
            _form = form;
        }
    }
}

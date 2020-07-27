using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class SettingsView : CommonView, ISettingsView
    {
        public SettingsView(Form form)
        {
            _form = form;
        }
    }
}

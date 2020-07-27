using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MacAddressView : CommonView, IMacAddressView
    {
        public MacAddressView(Form form)
        {
            _form = form;
        }
    }
}

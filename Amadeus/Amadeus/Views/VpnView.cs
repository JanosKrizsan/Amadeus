using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class VpnView : CommonView, IVpnView
    {
        public VpnView(Form form)
        {
            _form = form;
        }
    }
}

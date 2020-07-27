using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class IPAddressView : CommonView, IIpAddressView
    {
        public IPAddressView(Form form)
        {
            _form = form;
        }
    }
}

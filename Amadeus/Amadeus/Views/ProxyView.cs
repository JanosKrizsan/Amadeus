using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class ProxyView : CommonView, IProxyView
    {
        public ProxyView(Form form)
        {
            _form = form;
        }
    }
}

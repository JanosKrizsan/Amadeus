using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class RdpView : CommonView, IRdpView
    {
        public RdpView(Form form)
        {
            _form = form;
        }
    }
}


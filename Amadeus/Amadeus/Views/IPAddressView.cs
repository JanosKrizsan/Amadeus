using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class IPAddressView : CommonView, IIpAddressView
    {
        public IPAddressView(Form form)
        {
            _form = form;
        }

        public event EventHandler SetStaticAddress;
        public event EventHandler GenerateDynamicAddress;
        public event EventHandler GetAdapterData;
        public event EventHandler ShowHelp;
    }
}

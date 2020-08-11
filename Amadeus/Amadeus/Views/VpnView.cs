using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class VpnView : CommonView, IVpnView
    {
        public VpnView(Form form)
        {
            _form = form;
        }

        public event EventHandler ToggleSplitTunnel;
        public event EventHandler ToggleAvailableForAll;
        public event EventHandler SaveNewOrUpdate;
        public event EventHandler ClearValues;
        public event EventHandler ConnectToSelected;
        public event EventHandler EditSelected;
        public event EventHandler RemoveSelected;
        public event EventHandler ShowVpnHelp;
    }
}

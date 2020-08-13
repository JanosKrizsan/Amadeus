using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class VpnView : CommonView, IVpnView
    {
        public VpnView() : base(new Vpn())
        {
        }

        public event EventHandler ToggleSplitTunnel;
        public event EventHandler ToggleAvailableForAll;
        public event EventHandler SaveNewOrUpdate;
        public event EventHandler ClearValues;
        public event EventHandler ConnectToSelected;
        public event EventHandler EditSelected;
        public event EventHandler RemoveSelected;
        public event EventHandler ShowVpnHelp;

        public override void OnLoadCheck()
        {
        }

        public override void SetViewControls()
        {
        }

        public override void SubToEvents()
        {
        }
    }
}

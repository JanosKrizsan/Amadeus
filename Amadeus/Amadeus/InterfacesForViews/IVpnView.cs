using System;

namespace Amadeus.InterfacesForViews
{
    interface IVpnView : ICommonView
    {
        event EventHandler ToggleSplitTunnel;
        event EventHandler ToggleAvailableForAll;
        event EventHandler SaveNewOrUpdate;
        event EventHandler ClearValues;
        event EventHandler ConnectToSelected;
        event EventHandler EditSelected;
        event EventHandler RemoveSelected;
        event EventHandler ShowVpnHelp;
    }
}

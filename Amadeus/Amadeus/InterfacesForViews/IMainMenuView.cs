using System;

namespace Amadeus.InterfacesForViews
{
    interface IMainMenuView : ICommonView
    {
        event EventHandler OpenMainMenu;
        event EventHandler OpenSettings;
        event EventHandler OpenProxyTab;
        event EventHandler OpenVpnTab;
        event EventHandler OpenRdpTab;
        event EventHandler OpenIpAddrTab;
        event EventHandler OpenMacAddrTab;
        event EventHandler OpenSysLangTab;
        event EventHandler LogOut;
        event EventHandler Quit;
    }
}

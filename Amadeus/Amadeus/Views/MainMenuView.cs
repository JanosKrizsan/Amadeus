using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MainMenuView : CommonView, IMainMenuView
    {
        public MainMenuView(Form form)
        {
            _form = form;
        }

        public event EventHandler OpenMainMenu;
        public event EventHandler OpenSettings;
        public event EventHandler OpenProxyTab;
        public event EventHandler OpenVpnTab;
        public event EventHandler OpenRdpTab;
        public event EventHandler OpenIpAddrTab;
        public event EventHandler OpenMacAddrTab;
        public event EventHandler OpenSysLangTab;
        public event EventHandler LogOut;
        public event EventHandler Quit;
    }
}

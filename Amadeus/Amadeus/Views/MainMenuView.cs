using FormMainMenu = Amadeus.Forms.MainMenu;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class MainMenuView : CommonView, IMainMenuView
    {
        public MainMenuView() : base(new FormMainMenu())
        {
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

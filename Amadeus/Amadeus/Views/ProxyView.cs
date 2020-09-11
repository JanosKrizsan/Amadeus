using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class ProxyView : CommonView, IProxyView
    {
        public ProxyView() : base(new Proxy())
        {
        }

        public event EventHandler ImportFromTextFile;
        public event EventHandler ShowImportHelp;
        public event EventHandler SelectSaved;
        public event EventHandler ConnectToSeleted;
        public event EventHandler EditSelected;
        public event EventHandler DeleteSelected;
        public event EventHandler ToggleNewAuthReq;
        public event EventHandler SaveNewProxy;
        public event EventHandler SaveNewAndConnectTo;
        public event EventHandler ShowAddProxyHelp;

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

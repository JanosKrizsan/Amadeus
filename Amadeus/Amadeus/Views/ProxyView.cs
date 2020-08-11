using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class ProxyView : CommonView, IProxyView
    {
        public ProxyView(Form form)
        {
            _form = form;
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
    }
}

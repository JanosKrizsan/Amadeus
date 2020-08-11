using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class RdpView : CommonView, IRdpView
    {
        public RdpView(Form form)
        {
            _form = form;
        }

        public event EventHandler ToggleUseGateway;
        public event EventHandler ToggleAsAdmin;
        public event EventHandler ToggleRemoteGuard;
        public event EventHandler ToggleAsRestrAdmin;
        public event EventHandler ShowAddRdpHelp;
        public event EventHandler ToggleOnlyShowRdpFiles;
        public event EventHandler RefreshedSavedList;
        public event EventHandler ConnectToSeleted;
        public event EventHandler DeleteSelected;
        public event EventHandler EditSelected;
        public event EventHandler UpdateConnectionStatus;
        public event EventHandler RecheckConnectionStatus;
        public event EventHandler ToggleStartFullscreen;
        public event EventHandler ToggleMultiMonitorMode;
        public event EventHandler ToggleSpanMonitorsMode;
        public event EventHandler SaveOrUpdateNew;
        public event EventHandler SaveNewAsRdpFile;
        public event EventHandler SaveNewAsXmlFile;
        public event EventHandler QuickConnectToNew;
        public event EventHandler ResetFieldsToDef;
        public event EventHandler ShowRdpNewOptionsHelp;

        public void ReadScreenInfo()
        {
            throw new NotImplementedException();
        }
    }
}


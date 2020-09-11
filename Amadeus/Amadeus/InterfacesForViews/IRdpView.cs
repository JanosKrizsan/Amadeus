using System;

namespace Amadeus.InterfacesForViews
{
    interface IRdpView : ICommonView
    {
        event EventHandler ToggleUseGateway;
        event EventHandler ToggleAsAdmin;
        event EventHandler ToggleRemoteGuard;
        event EventHandler ToggleAsRestrAdmin;
        event EventHandler ShowAddRdpHelp;
        event EventHandler ToggleOnlyShowRdpFiles;
        event EventHandler RefreshedSavedList;
        event EventHandler ConnectToSeleted;
        event EventHandler DeleteSelected;
        event EventHandler EditSelected;
        event EventHandler UpdateConnectionStatus;
        event EventHandler RecheckConnectionStatus;
        event EventHandler ToggleStartFullscreen;
        event EventHandler ToggleMultiMonitorMode;
        event EventHandler ToggleSpanMonitorsMode;
        event EventHandler SaveOrUpdateNew;
        event EventHandler SaveNewAsRdpFile;
        event EventHandler SaveNewAsXmlFile;
        event EventHandler QuickConnectToNew;
        event EventHandler ResetFieldsToDef;
        event EventHandler ShowRdpNewOptionsHelp;
        void ReadScreenInfo();
    }
}

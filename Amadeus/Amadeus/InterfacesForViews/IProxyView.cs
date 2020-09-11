using System;

namespace Amadeus.InterfacesForViews
{
    interface IProxyView : ICommonView
    {
        event EventHandler ImportFromTextFile;
        event EventHandler ShowImportHelp;
        event EventHandler SelectSaved;
        event EventHandler ConnectToSeleted;
        event EventHandler EditSelected;
        event EventHandler DeleteSelected;
        event EventHandler ToggleNewAuthReq;
        event EventHandler SaveNewProxy;
        event EventHandler SaveNewAndConnectTo;
        event EventHandler ShowAddProxyHelp;
    }
}

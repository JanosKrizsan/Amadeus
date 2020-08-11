using System;

namespace Amadeus.InterfacesForViews
{
    interface IMainMenuSubView : ICommonView
    {
        event EventHandler UpdateProgressInfo;
        event EventHandler SaveReportToText;
        event EventHandler SaveReportToXML;
        event EventHandler SaveReportToCSV;
        event EventHandler ReadReportFile;
        event EventHandler ResetCurrentReport;
        event EventHandler AddScript;
        event EventHandler RemoveSelectedScript;
        event EventHandler RunCustomScript;
        event EventHandler StopCurrentProcess;
    }
}

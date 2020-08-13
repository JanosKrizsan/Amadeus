using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MainMenuSubView : CommonView, IMainMenuSubView
    {
        public MainMenuSubView(Form form)
        {
            _form = form;
        }

        public event EventHandler UpdateProgressInfo;
        public event EventHandler SaveReportToText;
        public event EventHandler SaveReportToXML;
        public event EventHandler SaveReportToCSV;
        public event EventHandler ReadReportFile;
        public event EventHandler ResetCurrentReport;
        public event EventHandler AddScript;
        public event EventHandler RemoveSelectedScript;
        public event EventHandler RunCustomScript;
        public event EventHandler StopCurrentProcess;
    }
}

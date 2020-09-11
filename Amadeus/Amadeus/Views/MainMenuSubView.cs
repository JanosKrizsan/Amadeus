using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class MainMenuSubView : CommonView, IMainMenuSubView
    {
        public MainMenuSubView() : base(new MainMenuSub())
        {
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

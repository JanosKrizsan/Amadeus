using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class SettingsView : CommonView, ISettingsView
    {
        public SettingsView() : base(new Settings())
        {
        }

        public event EventHandler ToggleAutoLogin;
        public event EventHandler ToggleNoDataSaved;
        public event EventHandler ToggleWipeDataOnQuit;
        public event EventHandler ToggleResetSysDefsOnQuit;
        public event EventHandler ToggleAlwaysPGP;
        public event EventHandler ToggleSendRepsInMail;
        public event EventHandler SetUserInfo;
        public event EventHandler ToggleForcePGPInMail;
        public event EventHandler SetEmail;
        public event EventHandler LoadSettings;
        public event EventHandler SaveSettings;
        public event EventHandler ReloadSettings;
        public event EventHandler UseRecommended;
        public event EventHandler AddNewUser;
        public event EventHandler RemoveExistingUser;
        public event EventHandler WipeAllData;
        public event EventHandler ShowSettingsHelp;

        public override void OnLoadCheck()
        {
        }

        public void ReadEmailInfo()
        {
        }

        public void ReadUserInfo()
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

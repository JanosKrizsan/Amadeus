using System;

namespace Amadeus.InterfacesForViews
{
    interface ISettingsView : ICommonView
    {
        event EventHandler ToggleAutoLogin;
        event EventHandler ToggleNoDataSaved;
        event EventHandler ToggleWipeDataOnQuit;
        event EventHandler ToggleResetSysDefsOnQuit;
        event EventHandler ToggleAlwaysPGP;
        event EventHandler ToggleSendRepsInMail;
        event EventHandler SetUserInfo;
        event EventHandler ToggleForcePGPInMail;
        event EventHandler SetEmail;
        event EventHandler LoadSettings;
        event EventHandler SaveSettings;
        event EventHandler ReloadSettings;
        event EventHandler UseRecommended;
        event EventHandler AddNewUser;
        event EventHandler RemoveExistingUser;
        event EventHandler WipeAllData;
        event EventHandler ShowSettingsHelp;

        void ReadUserInfo();
        void ReadEmailInfo();
    }
}

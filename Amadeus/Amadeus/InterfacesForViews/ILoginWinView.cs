using System;

namespace Amadeus.InterfacesForViews
{
    interface ILoginWinView : ICommonView
    {
        event EventHandler ToggleStayLoggedIn;
        event EventHandler ToggleSaveUserInfo;
        event EventHandler SelectSavedUser;
        event EventHandler Login;
        event EventHandler Register;
        event EventHandler Quit;

        void CheckStayLoggedIn();
        void SaveData();
        void AuthenticateLogin();
        void CrossCheckRegistered();
    }
}

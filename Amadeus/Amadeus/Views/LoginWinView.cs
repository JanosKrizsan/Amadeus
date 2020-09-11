using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class LoginWinView : CommonView, ILoginWinView
    {
        public LoginWinView() : base(new LoginWin())
        {
        }

        public event EventHandler ToggleStayLoggedIn;
        public event EventHandler ToggleSaveUserInfo;
        public event EventHandler SelectSavedUser;
        public event EventHandler Login;
        public event EventHandler Register;
        public event EventHandler Quit;

        public void AuthenticateLogin()
        {
        }

        public void CheckStayLoggedIn()
        {
        }

        public void CrossCheckRegistered()
        {
        }

        public override void OnLoadCheck()
        {
        }

        public void SaveData()
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

using Amadeus.InterfacesForViews;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class LoginWinView : CommonView, ILoginWinView
    {
        public LoginWinView(Form form)
        {
            _form = form;
        }

        public event EventHandler ToggleStayLoggedIn;
        public event EventHandler ToggleSaveUserInfo;
        public event EventHandler SelectSavedUser;
        public event EventHandler Login;
        public event EventHandler Register;
        public event EventHandler Quit;

        public void AuthenticateLogin()
        {
            throw new NotImplementedException();
        }

        public void CheckStayLoggedIn()
        {
            throw new NotImplementedException();
        }

        public void CrossCheckRegistered()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}

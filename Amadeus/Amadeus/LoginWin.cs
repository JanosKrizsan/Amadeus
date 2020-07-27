using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus
{
    public partial class LoginWin : Form, ILoginWinView
    {
        private LoginPresenter _presenter;

        public LoginWin()
        {
            _presenter = new LoginPresenter(new LoginModel(), this);
            InitializeComponent();
        }
    }
}

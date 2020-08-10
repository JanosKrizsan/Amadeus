using Amadeus.InterfacesForViews;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class LoginWinView : CommonView, ILoginWinView
    {
        public LoginWinView(Form form)
        {
            _form = form;
        }
    }
}

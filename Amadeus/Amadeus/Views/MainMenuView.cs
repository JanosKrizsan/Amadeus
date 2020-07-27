using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MainMenuView : CommonView, IMainMenuView
    {
        public MainMenuView(Form form)
        {
            _form = form;
        }
    }
}

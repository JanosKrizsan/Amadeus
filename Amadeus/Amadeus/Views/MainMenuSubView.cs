using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MainMenuSubView : CommonView, IMainMenuSubView
    {
        public MainMenuSubView(Form form)
        {
            _form = form;
        }
    }
}

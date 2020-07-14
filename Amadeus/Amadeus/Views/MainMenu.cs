using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class MainMenu : Form, IMainMenuPres
    {
        private MainMenuPresenter _presenter;
        public MainMenu()
        {
            _presenter = new MainMenuPresenter(new MainMenuModel(), this);
            InitializeComponent();
        }
    }
}

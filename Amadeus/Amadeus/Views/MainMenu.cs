using Amadeus.InterfacesForViews;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class MainMenu : Form, IMainMenu
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainMenuSelectPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

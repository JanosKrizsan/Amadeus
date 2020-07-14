using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class MacAddress : Form, IMacAddressPres
    {
        private MacPresenter _presenter;
        public MacAddress()
        {
            _presenter = new MacPresenter(new MacModel(), this);
            InitializeComponent();
        }
    }
}

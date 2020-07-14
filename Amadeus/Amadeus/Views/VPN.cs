using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class Vpn : Form, IVpnPres
    {
        private VpnPresenter _presenter;
        public Vpn()
        {
            _presenter = new VpnPresenter(new VpnModel(), this);
            InitializeComponent();
        }
    }
}

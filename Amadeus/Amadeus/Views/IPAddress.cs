using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class IPAddress : Form, IIPAddressPres
    {
        private IPPresenter _presenter;
        public IPAddress()
        {
            _presenter = new IPPresenter(new IPModel(), this);
            InitializeComponent();
        }

    }
}

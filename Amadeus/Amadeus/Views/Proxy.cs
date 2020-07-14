using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class Proxy : Form, IProxyPres
    {
        private ProxyPresenter _presenter;

        public Proxy()
        {
            _presenter = new ProxyPresenter(new ProxyModel(), this);
            InitializeComponent();
        }
    }
}

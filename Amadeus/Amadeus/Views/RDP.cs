using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class Rdp : Form, IRdpPres
    {
        private RdpPresenter _presenter;
        public Rdp()
        {
            _presenter = new RdpPresenter(new RdpModel(), this);
            InitializeComponent();
        }
    }
}

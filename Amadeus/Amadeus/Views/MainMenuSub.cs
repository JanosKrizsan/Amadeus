using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class MainMenuSub : Form, IMainMenuSubPres
    {
        private MainMenuSubPresenter _presenter;
        public MainMenuSub()
        {
            _presenter = new MainMenuSubPresenter(new MainMenuSubModel(), this);
            InitializeComponent();
        }
    }
}

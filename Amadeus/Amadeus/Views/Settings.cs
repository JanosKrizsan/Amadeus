using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class Settings : Form, ISettingsPres
    {
        private SettingsPresenter _presenter;
        public Settings()
        {
            _presenter = new SettingsPresenter(new SettingsModel(), this);
            InitializeComponent();
        }
    }
}

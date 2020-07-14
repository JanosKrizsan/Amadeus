using Amadeus.InterfacesForViews;
using Amadeus.Models;
using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus.Views
{
    public partial class SysLanguage : Form, ISysLangPres
    {
        private SysLangPresenter _presenter;
        public SysLanguage()
        {
            _presenter = new SysLangPresenter(new SysLangModel(), this);
            InitializeComponent();
        }
    }
}

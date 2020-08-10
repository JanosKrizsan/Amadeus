using Amadeus.InterfacesForViews;
using System.Windows.Forms;

namespace Amadeus.Views
{
    abstract class CommonView : ICommonView
    {
        internal Form _form;
        public void ShowForm()
        {
            _form.ShowDialog();
        }
    }
}

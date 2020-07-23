using Amadeus.InterfacesForViews;
using System.Windows.Forms;

namespace Amadeus.Views
{
    abstract class CommonView : ICommon
    {
        Form form;
        public void ShowForm()
        {
            form.ShowDialog();
        }
    }
}

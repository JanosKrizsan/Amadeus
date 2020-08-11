using Amadeus.InterfacesForViews;
using System;
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
        public void CloseForm()
        {
            _form.Close();
        }

        public void OnLoadCheck()
        {
            throw new NotImplementedException();
        }
    }
}

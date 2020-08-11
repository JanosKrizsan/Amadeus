using System;
using System.Windows.Forms;

namespace Amadeus.InterfacesForViews
{
    interface ICommonView
    {
        void OnLoadCheck();
        void ShowForm();
        void CloseForm();
    }
}

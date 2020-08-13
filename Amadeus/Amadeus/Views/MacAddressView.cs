using Amadeus.InterfacesForViews;
using Amadeus.Models;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class MacAddressView : CommonView, IMacAddressView
    {
        public MacAddressView(Form form)
        {
            _form = form;
        }

        public event EventHandler SelectionClick;
        public event EventHandler AddSelected;
        public event EventHandler GenerateRandomAddress;
        public event EventHandler GenerateNonVendorPart;
        public event EventHandler ApplyFullAddress;
        public event EventHandler SaveAddress;
        public event EventHandler ApplySavedAddr;
        public event EventHandler RemoveSavedAddr;
        public event EventHandler ShowHelp;
    }
}

using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class MacAddressView : CommonView, IMacAddressView
    {
        public MacAddressView() : base(new MacAddress())
        {
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

        public override void OnLoadCheck()
        {
        }

        public override void SetViewControls()
        {
        }

        public override void SubToEvents()
        {
        }
    }
}

using Amadeus.Forms;
using Amadeus.InterfacesForViews;
using System;

namespace Amadeus.Views
{
    class IPAddressView : CommonView, IIpAddressView
    {
        public IPAddressView() : base(new IPAddress())
        {
        }

        public event EventHandler SetStaticAddress;
        public event EventHandler GenerateDynamicAddress;
        public event EventHandler GetAdapterData;
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

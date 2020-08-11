using System;

namespace Amadeus.InterfacesForViews
{
    interface IIpAddressView : ICommonView
    {
        event EventHandler SetStaticAddress;
        event EventHandler GenerateDynamicAddress;
        event EventHandler GetAdapterData;
        event EventHandler ShowHelp;

    }
}

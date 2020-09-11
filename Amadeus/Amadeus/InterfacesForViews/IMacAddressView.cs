using System;

namespace Amadeus.InterfacesForViews
{
    interface IMacAddressView : ICommonView
    {
        event EventHandler SelectionClick;
        event EventHandler AddSelected;
        event EventHandler GenerateRandomAddress;
        event EventHandler GenerateNonVendorPart;
        event EventHandler ApplyFullAddress;
        event EventHandler SaveAddress;
        event EventHandler ApplySavedAddr;
        event EventHandler RemoveSavedAddr;
        event EventHandler ShowHelp;
    }
}

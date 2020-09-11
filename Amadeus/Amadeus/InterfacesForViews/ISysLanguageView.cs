using System;

namespace Amadeus.InterfacesForViews
{
    interface ISysLanguageView : ICommonView
    {
        event EventHandler RemoveSelected;
        event EventHandler SetSelected;
        event EventHandler SetSelectedAsDefault;
        event EventHandler ResetToDefault;
        event EventHandler CheckGeoData;
        event EventHandler AddCustomTag;
        event EventHandler AddAndSetCustTag;
        event EventHandler RemoveSimilarTags;
        event EventHandler ShowLangTagsHelp;
        event EventHandler AddNewFromList;
        event EventHandler AddAndSetNewFromList;
        event EventHandler ShowLangListHelp;
    }
}

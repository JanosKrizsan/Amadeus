using Amadeus.InterfacesForViews;
using System;
using System.Windows.Forms;

namespace Amadeus.Views
{
    class SysLangView : CommonView, ISysLanguageView
    {
        public SysLangView(Form form) : base(form)
        {
        }

        public event EventHandler RemoveSelected;
        public event EventHandler SetSelected;
        public event EventHandler SetSelectedAsDefault;
        public event EventHandler ResetToDefault;
        public event EventHandler CheckGeoData;
        public event EventHandler AddCustomTag;
        public event EventHandler AddAndSetCustTag;
        public event EventHandler RemoveSimilarTags;
        public event EventHandler ShowLangTagsHelp;
        public event EventHandler AddNewFromList;
        public event EventHandler AddAndSetNewFromList;
        public event EventHandler ShowLangListHelp;

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
